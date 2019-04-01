using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIDO_BE.Migrations
{
    public partial class tri5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngay",
                table: "ADUserGroups");

            migrationBuilder.DropColumn(
                name: "Ngay1",
                table: "ADUserGroups");

            migrationBuilder.AlterColumn<string>(
                name: "ADUserGroupName",
                table: "ADUserGroups",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ADUserGroupDesc",
                table: "ADUserGroups",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AAStatus",
                table: "ADUserGroups",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactAddressStreet = table.Column<int>(nullable: true),
                    ContactAddressLine = table.Column<int>(nullable: true),
                    ContactAddressCity = table.Column<int>(nullable: true),
                    ContactAddressPostalCode = table.Column<int>(nullable: true),
                    ContactAddressStateProvince = table.Column<int>(nullable: true),
                    ContactAddressZipCode = table.Column<int>(nullable: true),
                    ContactAddressCountry = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "ADUsers",
                columns: table => new
                {
                    ADUserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(maxLength: 10, nullable: true),
                    ADUserGroupID = table.Column<int>(nullable: false),
                    FK_ReferenceID = table.Column<int>(nullable: true),
                    ADUserName = table.Column<string>(maxLength: 100, nullable: true),
                    ADPassword = table.Column<string>(maxLength: 100, nullable: true),
                    ADUserActiveCheck = table.Column<bool>(nullable: true),
                    AACreatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    AAUpdatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    ADUserResetToken = table.Column<string>(maxLength: 500, nullable: true),
                    ADUserDate = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADUsers", x => x.ADUserID);
                    table.ForeignKey(
                        name: "FK_ADUsers_ADUserGroups_ADUserGroupID",
                        column: x => x.ADUserGroupID,
                        principalTable: "ADUserGroups",
                        principalColumn: "ADUserGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GENumberings",
                columns: table => new
                {
                    GENumberingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(maxLength: 50, nullable: true),
                    GENumberingName = table.Column<string>(maxLength: 50, nullable: true),
                    GENumberingPrefix = table.Column<int>(nullable: true),
                    GENumberingLength = table.Column<int>(nullable: true),
                    GENumberingStart = table.Column<int>(nullable: true),
                    GENumberingDesc = table.Column<string>(maxLength: 50, nullable: true),
                    GETableName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENumberings", x => x.GENumberingID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(maxLength: 10, nullable: true),
                    AACreatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AAUpdatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AACreatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    AAUpdatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeNo = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 150, nullable: true),
                    EmployeeGender = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeBirthDay = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeDesc = table.Column<string>(maxLength: 255, nullable: true),
                    EmployeePicture = table.Column<string>(nullable: true),
                    EmployeeIDNumber = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeIDNumberPlace = table.Column<string>(maxLength: 150, nullable: true),
                    EmployeeIDNumberDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeePassportNo = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeePassportDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeePassportPlace = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeTaxNumber = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeActiveCheck = table.Column<bool>(nullable: true),
                    EmployeeStartWorkingDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeEndWorkingDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeStartWorkingTime = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeEndWorkingTime = table.Column<DateTime>(type: "DateTime", nullable: true),
                    EmployeeTel1 = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeTel2 = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeEmail1 = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeePassword1 = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeEmail2 = table.Column<string>(maxLength: 50, nullable: true),
                    EmployeeFax = table.Column<string>(maxLength: 50, nullable: true),
                    FK_AddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Addresses_FK_AddressID",
                        column: x => x.FK_AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(maxLength: 10, nullable: true),
                    AACreatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AAUpdatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AACreatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    AAUpdatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    PatientNo = table.Column<string>(maxLength: 50, nullable: false),
                    PatientName = table.Column<string>(maxLength: 150, nullable: true),
                    PatientGender = table.Column<string>(maxLength: 50, nullable: true),
                    PatientBirthDay = table.Column<DateTime>(type: "DateTime", nullable: false),
                    PatientDesc = table.Column<string>(maxLength: 255, nullable: true),
                    PatientPicture = table.Column<string>(nullable: true),
                    PatientIDNumber = table.Column<string>(maxLength: 50, nullable: true),
                    PatientIDNumberPlace = table.Column<string>(maxLength: 150, nullable: true),
                    PatientIDNumberDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    PatientTel = table.Column<string>(maxLength: 50, nullable: true),
                    PatientEmail = table.Column<string>(maxLength: 50, nullable: true),
                    FK_AddressID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patients_Addresses_FK_AddressID",
                        column: x => x.FK_AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(maxLength: 50, nullable: true),
                    AACreatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AAUpdatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AACreatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    AAUpdatedDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DoctorNo = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorName = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorAvatar = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorBirthDay = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DoctorDesc = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorGender = table.Column<string>(maxLength: 10, nullable: true),
                    DoctorStatus = table.Column<string>(maxLength: 10, nullable: true),
                    DoctorIDNumber = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorIDNumberPlace = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorIDNumberDate = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorPassportNo = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorPassportDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DoctorPassportPlace = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorPhone1 = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorPhone2 = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorEmail = table.Column<string>(maxLength: 50, nullable: true),
                    FK_EmployeeID = table.Column<int>(nullable: true),
                    DoctorSpecialist = table.Column<string>(maxLength: 10, nullable: true),
                    HospitalName = table.Column<string>(maxLength: 10, nullable: true),
                    EmployeeName = table.Column<string>(maxLength: 10, nullable: true),
                    FK_AddressID = table.Column<int>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_Doctors_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Addresses_FK_AddressID",
                        column: x => x.FK_AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(maxLength: 50, nullable: true),
                    AACreatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AAUpdatedUser = table.Column<string>(maxLength: 50, nullable: true),
                    AACreatedDate = table.Column<string>(maxLength: 50, nullable: true),
                    AAUpdatedDate = table.Column<string>(maxLength: 50, nullable: true),
                    PostNo = table.Column<string>(maxLength: 50, nullable: true),
                    PostContent = table.Column<string>(maxLength: 1024, nullable: true),
                    FK_EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Posts_Employees_FK_EmployeeID",
                        column: x => x.FK_EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FeedbackDesc = table.Column<string>(maxLength: 500, nullable: true),
                    FeedbackDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Patients_FK_PatientID",
                        column: x => x.FK_PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CertificateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CertificateStatus = table.Column<string>(maxLength: 50, nullable: true),
                    CertificateDesc = table.Column<string>(nullable: true),
                    CertificatePicture1 = table.Column<string>(nullable: true),
                    CertificatePicture2 = table.Column<string>(nullable: true),
                    CertificatePicture3 = table.Column<string>(nullable: true),
                    CertificateDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CertificateID);
                    table.ForeignKey(
                        name: "FK_Certificates_Doctors_FK_DoctorID",
                        column: x => x.FK_DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Certificates_Employees_FK_EmployeeID",
                        column: x => x.FK_EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentContent = table.Column<string>(maxLength: 500, nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true),
                    CommentStatus = table.Column<string>(maxLength: 10, nullable: true),
                    CommentReportDesc = table.Column<string>(maxLength: 500, nullable: true),
                    CommentDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    DoctorID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true),
                    ContactContent = table.Column<string>(maxLength: 500, nullable: true),
                    ContactStatus = table.Column<string>(maxLength: 50, nullable: true),
                    DoctorID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contacts_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    ForumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ForumContent = table.Column<string>(maxLength: 500, nullable: true),
                    ForumDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.ForumID);
                    table.ForeignKey(
                        name: "FK_Forums_Doctors_FK_PatientID",
                        column: x => x.FK_PatientID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Forums_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationLongitude = table.Column<string>(maxLength: 50, nullable: true),
                    LocationLatitude = table.Column<string>(maxLength: 50, nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Location_Doctors_FK_PatientID",
                        column: x => x.FK_PatientID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RatingDate = table.Column<string>(maxLength: 10, nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true),
                    RatingIndex = table.Column<int>(nullable: true),
                    DoctorID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Ratings_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ForumDetails",
                columns: table => new
                {
                    ForumDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ForumDetailContent = table.Column<string>(maxLength: 500, nullable: true),
                    ForumDetailDate = table.Column<DateTime>(type: "DateTime", nullable: true),
                    FK_ForumID = table.Column<int>(nullable: true),
                    FK_DoctorID = table.Column<int>(nullable: true),
                    FK_PatientID = table.Column<int>(nullable: true),
                    ForumID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumDetails", x => x.ForumDetailID);
                    table.ForeignKey(
                        name: "FK_ForumDetails_Doctors_FK_PatientID",
                        column: x => x.FK_PatientID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumDetails_Forums_ForumID",
                        column: x => x.ForumID,
                        principalTable: "Forums",
                        principalColumn: "ForumID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ForumDetails_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADUsers_ADUserGroupID",
                table: "ADUsers",
                column: "ADUserGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_FK_DoctorID",
                table: "Certificates",
                column: "FK_DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_FK_EmployeeID",
                table: "Certificates",
                column: "FK_EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DoctorID",
                table: "Comments",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PatientID",
                table: "Comments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DoctorID",
                table: "Contacts",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PatientID",
                table: "Contacts",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_EmployeeID",
                table: "Doctors",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_FK_AddressID",
                table: "Doctors",
                column: "FK_AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FK_AddressID",
                table: "Employees",
                column: "FK_AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_FK_PatientID",
                table: "Feedbacks",
                column: "FK_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_FK_PatientID",
                table: "ForumDetails",
                column: "FK_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_ForumID",
                table: "ForumDetails",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_ForumDetails_PatientID",
                table: "ForumDetails",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_FK_PatientID",
                table: "Forums",
                column: "FK_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_PatientID",
                table: "Forums",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_FK_PatientID",
                table: "Location",
                column: "FK_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_PatientID",
                table: "Location",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_FK_AddressID",
                table: "Patients",
                column: "FK_AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FK_EmployeeID",
                table: "Posts",
                column: "FK_EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_DoctorID",
                table: "Ratings",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PatientID",
                table: "Ratings",
                column: "PatientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADUsers");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "ForumDetails");

            migrationBuilder.DropTable(
                name: "GENumberings");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "ADUserGroupName",
                table: "ADUserGroups",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ADUserGroupDesc",
                table: "ADUserGroups",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AAStatus",
                table: "ADUserGroups",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngay",
                table: "ADUserGroups",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngay1",
                table: "ADUserGroups",
                type: "datetime",
                nullable: true);
        }
    }
}
