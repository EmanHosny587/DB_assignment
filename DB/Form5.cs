using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form5 : Form
    {
        string connectionString = @"Data Source=DESKTOP-058A3R7\MSSQLSERVER01;Initial Catalog=Hospital_managment;Integrated Security=True;Encrypt=True;Trust Server Certificate=Truee";

        public Form5()
        {
            InitializeComponent();

            btnTopSpecialty.Click += btnTopSpecialty_Click;
            btnNoConsult.Click += btnNoConsult_Click;
            btnTopMeds.Click += btnTopMeds_Click;
            btnBranch.Click += btnBranch_Click;
            btnDiagnosis.Click += btnDiagnosis_Click;
            btnPatientPrescription.Click += btnPatientPrescription_Click;
            btnBack.Click += btnBack_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadTopSpecialty();

        }
        //buttons
        private void btnTopSpecialty_Click(object sender, EventArgs e)
        {
            LoadTopSpecialty();
        }
        private void btnNoConsult_Click(object sender, EventArgs e)
        {
            LoadNoConsult();

        }
        private void btnTopMeds_Click(object sender, EventArgs e)
        {
            LoadTopMeds();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            LoadTopBranch();
        }
        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            LoadDiagnosisByBranch();
        }
        private void btnPatientPrescription_Click(object sender, EventArgs e)
        {
            LoadPatientPrescriptions();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        //functions
        private void LoadTopSpecialty()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                   SELECT TOP 1
    S.SPECIALITY_NAME,
    COUNT(C.CONSULTATION_ID) AS TotalConsultations
FROM SPECIALITY S
JOIN PRACTITIONER P
    ON S.SPECIALITY_ID = P.SPECIALITY_ID
JOIN CLINIC_CONSULTATION C
    ON P.PRACTITIONER_ID = C.PRACTITIONER_ID
WHERE MONTH(C.CONSULTATION_DATE) = MONTH(DATEADD(MONTH,-1,GETDATE()))
AND YEAR(C.CONSULTATION_DATE) = YEAR(GETDATE())
GROUP BY S.SPECIALITY_NAME
ORDER BY TotalConsultations DESC;
                           ";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }
        private void LoadNoConsult()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT
    P.PRACTITIONER_ID,
    P.MEDICAL_EXPERTISE
FROM PRACTITIONER P
LEFT JOIN CLINIC_CONSULTATION C
    ON P.PRACTITIONER_ID = C.PRACTITIONER_ID
    AND MONTH(C.CONSULTATION_DATE) =
        MONTH(DATEADD(MONTH,-1,GETDATE()))
    AND YEAR(C.CONSULTATION_DATE) =
        YEAR(GETDATE())
WHERE C.CONSULTATION_ID IS NULL; ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
        }


        private void LoadTopMeds()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT TOP 1
    P.PATIENT_ID,
    P.DEMOGRAPHIC,
    COUNT(DISTINCT PD.MEDICATION_ID) AS DifferentMedications
FROM PATIENT P

JOIN CLINIC_CONSULTATION C
    ON P.PATIENT_ID = C.PATIENT_ID

JOIN CLINICAL_SUMMARY CS
    ON C.CLINICAL_SUMMARY_ID = CS.CLINICAL_SUMMARY_ID

JOIN PRESCRIPTION PR
    ON CS.CLINICAL_SUMMARY_ID = PR.CLINICAL_SUMMARY_ID

JOIN PRESCRIBEDIN PD
    ON PR.PRESCRIPTION_ID = PD.PRESCRIPTION_ID

WHERE MONTH(C.CONSULTATION_DATE) =
      MONTH(DATEADD(MONTH,-1,GETDATE()))
AND YEAR(C.CONSULTATION_DATE) =
    YEAR(GETDATE())

GROUP BY
    P.PATIENT_ID,
    P.DEMOGRAPHIC

ORDER BY DifferentMedications DESC; ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

      
        
        private void LoadTopBranch()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT TOP 1
    B.FACILITY_BRANCH_ID,
    B.PHYSICAL_ADDRESS,
    COUNT(DISTINCT C.PATIENT_ID) AS TotalPatients
FROM MEDICAL_FACILITY_BRANCH B

JOIN CLINIC_CONSULTATION C
    ON B.FACILITY_BRANCH_ID = C.FACILITY_BRANCH_ID

WHERE MONTH(C.CONSULTATION_DATE) =
      MONTH(DATEADD(MONTH,-1,GETDATE()))
AND YEAR(C.CONSULTATION_DATE) =
    YEAR(GETDATE())

GROUP BY
    B.FACILITY_BRANCH_ID,
    B.PHYSICAL_ADDRESS

ORDER BY TotalPatients DESC; ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void LoadDiagnosisByBranch()
        {
            if (string.IsNullOrWhiteSpace(txtBranchID.Text) || !int.TryParse(txtBranchID.Text, out int branchId))
            {
                MessageBox.Show("Warning: Please enter a valid branch ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
        SELECT
            CS.DIAGNOSIS,
            C.CONSULTATION_ID,
            C.FACILITY_BRANCH_ID,
            C.CONSULTATION_DATE

        FROM CLINICAL_SUMMARY CS

        JOIN CLINIC_CONSULTATION C
            ON CS.CLINICAL_SUMMARY_ID = C.CLINICAL_SUMMARY_ID

        WHERE C.FACILITY_BRANCH_ID = @BranchID

        AND MONTH(C.CONSULTATION_DATE) =
            MONTH(DATEADD(MONTH,-1,GETDATE()))

        AND YEAR(C.CONSULTATION_DATE) =
            YEAR(GETDATE())";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BranchID", branchId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }



        private void LoadPatientPrescriptions()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
        SELECT
            P.PATIENT_ID,
            P.CONTACT_HISTORY,
            P.DEMOGRAPHIC,
            COUNT(PR.PRESCRIPTION_ID) AS TotalPrescriptions

        FROM PATIENT P

        LEFT JOIN CLINIC_CONSULTATION C
            ON P.PATIENT_ID = C.PATIENT_ID

        LEFT JOIN CLINICAL_SUMMARY CS
            ON C.CLINICAL_SUMMARY_ID = CS.CLINICAL_SUMMARY_ID

        LEFT JOIN PRESCRIPTION PR
            ON CS.CLINICAL_SUMMARY_ID = PR.CLINICAL_SUMMARY_ID

        GROUP BY
            P.PATIENT_ID,
            P.CONTACT_HISTORY,
            P.DEMOGRAPHIC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

       
    }


}
