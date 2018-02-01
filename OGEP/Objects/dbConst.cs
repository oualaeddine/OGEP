using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGEP.Objects
{
    class dbConst
    {
        public static readonly string connectionString = 
            "Data Source = (localDB)\\creche_db;"+
            "AttachDbFilename=|DataDirectory|\\Creche_db.mdf;"+
            "Integrated Security = True;";

        public static readonly string addStud =
            "INSERT INTO [dbo].[Students] "+
            " ([Name], [FamilyName], [Adresse], [Phone], [AlterPhone], [Niveau], [date], [userId])" + 
            " VALUES "+
            " (@Name, @FamilyName,  @Adresse, @Phone, @AlterPhone, @niveau, @date, @userId);" + 
            " SELECT SCOPE_IDENTITY();";


        public static readonly string addProf =
             "INSERT INTO [dbo].[Profs] " +
             " ([Name], [FamilyName], [Adresse], [Phone],[userId], [date],[monthly],[prixNormal],[prixVip],[pourcentage],[autre]) "+
             " VALUES "+
             " (@Name, @FamilyName, @Adresse, @Phone, @userId, @date, @monthly, @prixNormal, @prixVip, @percent, @other)"+
             " SELECT SCOPE_IDENTITY();";

        public static readonly string addModule =
            "INSERT INTO dbo.Modules "+
            " (Matiere, profId, year, userId,date) "+
            " VALUES "+
            " (@matiere, @profId, @niveau, @userId,@date);"+
                         " SELECT SCOPE_IDENTITY();";
        public static readonly string addStudModule =
            "INSERT INTO [dbo].[StudModule]  " +
            " ( [StudentId], [ModuleId], [userId],[date])  " +
            " VALUES " +
            " (@studId, @moduleId, @userId, @date)";
        internal static readonly string addGroup=
            " INSERT INTO[dbo].[Groups]" +
            " ([name], [capacite], [moduleId], [date], [userId] )"+
            " VALUES"+
            " (@groupName, NULL, @moduleId, @date, @userId);";
    }
}
