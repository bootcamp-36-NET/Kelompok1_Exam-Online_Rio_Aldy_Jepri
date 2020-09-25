using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamOnline.Migrations
{
    public partial class RioAddIitTabel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "tb_t_examination",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_t_examination_SubjectId",
                table: "tb_t_examination",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_t_examination_tb_m_subjects_SubjectId",
                table: "tb_t_examination",
                column: "SubjectId",
                principalTable: "tb_m_subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_t_examination_tb_m_subjects_SubjectId",
                table: "tb_t_examination");

            migrationBuilder.DropIndex(
                name: "IX_tb_t_examination_SubjectId",
                table: "tb_t_examination");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectId",
                table: "tb_t_examination",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
