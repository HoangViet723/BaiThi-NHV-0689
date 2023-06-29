using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThi_NHV.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_NHVCau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenSV",
                table: "NHV_Cau3",
                newName: "NHVTenSV");

            migrationBuilder.RenameColumn(
                name: "SDT",
                table: "NHV_Cau3",
                newName: "NHVSDT");

            migrationBuilder.RenameColumn(
                name: "MaSV",
                table: "NHV_Cau3",
                newName: "NHVMaSV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NHVTenSV",
                table: "NHV_Cau3",
                newName: "TenSV");

            migrationBuilder.RenameColumn(
                name: "NHVSDT",
                table: "NHV_Cau3",
                newName: "SDT");

            migrationBuilder.RenameColumn(
                name: "NHVMaSV",
                table: "NHV_Cau3",
                newName: "MaSV");
        }
    }
}
