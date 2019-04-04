using Microsoft.EntityFrameworkCore.Migrations;

namespace FIDO_BE.Migrations
{
    public partial class tri8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Doctors_DoctorID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Patients_PatientID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Doctors_DoctorID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Patients_PatientID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Employees_EmployeeID",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumDetails_Doctors_FK_PatientID",
                table: "ForumDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumDetails_Forums_ForumID",
                table: "ForumDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumDetails_Patients_PatientID",
                table: "ForumDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Doctors_FK_PatientID",
                table: "Forums");

            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Patients_PatientID",
                table: "Forums");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Doctors_FK_PatientID",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Patients_PatientID",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Doctors_DoctorID",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Patients_PatientID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_DoctorID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_PatientID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Location_PatientID",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Forums_PatientID",
                table: "Forums");

            migrationBuilder.DropIndex(
                name: "IX_ForumDetails_ForumID",
                table: "ForumDetails");

            migrationBuilder.DropIndex(
                name: "IX_ForumDetails_PatientID",
                table: "ForumDetails");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_EmployeeID",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_DoctorID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PatientID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DoctorID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PatientID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "ForumID",
                table: "ForumDetails");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "ForumDetails");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Comments");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_FK_DoctorID",
                table: "Ratings",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_FK_PatientID",
                table: "Ratings",
                column: "FK_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_FK_DoctorID",
                table: "Location",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_FK_DoctorID",
                table: "Forums",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_FK_DoctorID",
                table: "ForumDetails",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_FK_ForumID",
                table: "ForumDetails",
                column: "FK_ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_FK_EmployeeID",
                table: "Doctors",
                column: "FK_EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FK_DoctorID",
                table: "Contacts",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FK_PatientID",
                table: "Contacts",
                column: "FK_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FK_DoctorID",
                table: "Comments",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FK_PatientID",
                table: "Comments",
                column: "FK_PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Doctors_FK_DoctorID",
                table: "Comments",
                column: "FK_DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Patients_FK_PatientID",
                table: "Comments",
                column: "FK_PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Doctors_FK_DoctorID",
                table: "Contacts",
                column: "FK_DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Patients_FK_PatientID",
                table: "Contacts",
                column: "FK_PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Employees_FK_EmployeeID",
                table: "Doctors",
                column: "FK_EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumDetails_Doctors_FK_DoctorID",
                table: "ForumDetails",
                column: "FK_DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumDetails_Forums_FK_ForumID",
                table: "ForumDetails",
                column: "FK_ForumID",
                principalTable: "Forums",
                principalColumn: "ForumID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumDetails_Patients_FK_PatientID",
                table: "ForumDetails",
                column: "FK_PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Doctors_FK_DoctorID",
                table: "Forums",
                column: "FK_DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Patients_FK_PatientID",
                table: "Forums",
                column: "FK_PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Doctors_FK_DoctorID",
                table: "Location",
                column: "FK_DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Patients_FK_PatientID",
                table: "Location",
                column: "FK_PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Doctors_FK_DoctorID",
                table: "Ratings",
                column: "FK_DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Patients_FK_PatientID",
                table: "Ratings",
                column: "FK_PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Doctors_FK_DoctorID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Patients_FK_PatientID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Doctors_FK_DoctorID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Patients_FK_PatientID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Employees_FK_EmployeeID",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumDetails_Doctors_FK_DoctorID",
                table: "ForumDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumDetails_Forums_FK_ForumID",
                table: "ForumDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumDetails_Patients_FK_PatientID",
                table: "ForumDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Doctors_FK_DoctorID",
                table: "Forums");

            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Patients_FK_PatientID",
                table: "Forums");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Doctors_FK_DoctorID",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Patients_FK_PatientID",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Doctors_FK_DoctorID",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Patients_FK_PatientID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_FK_DoctorID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_FK_PatientID",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Location_FK_DoctorID",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Forums_FK_DoctorID",
                table: "Forums");

            migrationBuilder.DropIndex(
                name: "IX_ForumDetails_FK_DoctorID",
                table: "ForumDetails");

            migrationBuilder.DropIndex(
                name: "IX_ForumDetails_FK_ForumID",
                table: "ForumDetails");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_FK_EmployeeID",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FK_DoctorID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FK_PatientID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FK_DoctorID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FK_PatientID",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Ratings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Ratings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Forums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForumID",
                table: "ForumDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "ForumDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Doctors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_DoctorID",
                table: "Ratings",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PatientID",
                table: "Ratings",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_PatientID",
                table: "Location",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_PatientID",
                table: "Forums",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_ForumID",
                table: "ForumDetails",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_PatientID",
                table: "ForumDetails",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_EmployeeID",
                table: "Doctors",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DoctorID",
                table: "Contacts",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PatientID",
                table: "Contacts",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DoctorID",
                table: "Comments",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PatientID",
                table: "Comments",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Doctors_DoctorID",
                table: "Comments",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Patients_PatientID",
                table: "Comments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Doctors_DoctorID",
                table: "Contacts",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Patients_PatientID",
                table: "Contacts",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Employees_EmployeeID",
                table: "Doctors",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumDetails_Doctors_FK_PatientID",
                table: "ForumDetails",
                column: "FK_PatientID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumDetails_Forums_ForumID",
                table: "ForumDetails",
                column: "ForumID",
                principalTable: "Forums",
                principalColumn: "ForumID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumDetails_Patients_PatientID",
                table: "ForumDetails",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Doctors_FK_PatientID",
                table: "Forums",
                column: "FK_PatientID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Patients_PatientID",
                table: "Forums",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Doctors_FK_PatientID",
                table: "Location",
                column: "FK_PatientID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Patients_PatientID",
                table: "Location",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Doctors_DoctorID",
                table: "Ratings",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Patients_PatientID",
                table: "Ratings",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
