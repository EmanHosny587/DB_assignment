Hospital Dashboard C# SQL Controls - REAL TABLE VERSION

This zip uses your actual table names:
- CLINICAL_SUMMARY
- IS_SCHEDULED
- MEDICAL_FACILITY_BRANCH
- MEDICATION
- PATIENT
- PRACTITIONER
- PRACTITIONER_BRANCH
- PRESCRIBEDIN
- PRESCRIPTION
- REGIONAL_HEALTHCARE_PROVIDER
- SPECIALITY

Pages/controls included:
1. HomeControl
2. PatientsControl
3. SpecialitiesControl
4. PractitionersControl
5. SchedulesControl uses IS_SCHEDULED
6. MedicationsControl
7. ReportsControl with joins

How to use:
1. Add all .cs files to your DB project.
2. Replace Program.cs with the included Program.cs.
3. Make sure your namespace is DB. If not, replace "namespace DB" in all files.
4. Connection string is in DatabaseHelper.cs.
5. Build and run.

Notes:
- There is no APPOINTMENT table in this version.
- The Schedules page uses IS_SCHEDULED instead.
- Delete operations may fail if rows are referenced by foreign keys. This is normal in SQL Server.