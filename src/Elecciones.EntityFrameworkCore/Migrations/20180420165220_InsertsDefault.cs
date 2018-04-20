using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Elecciones.Migrations
{
    public partial class InsertsDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [dbo].[AbpRoles]([ConcurrencyStamp],[CreationTime],[CreatorUserId],[DisplayName],[IsDefault],[IsDeleted],[IsStatic],[Name],[NormalizedName],[Description]) VALUES
            (Convert(nvarchar(max),NEWID()),GETDATE(),NULL,'Candidato',0,0,1,'Candidato','Candidato','Candidato'),
		    (Convert(nvarchar(max),NEWID()),GETDATE(),NULL,'Elector',0,0,1,'Elector','Elector','Elector')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
