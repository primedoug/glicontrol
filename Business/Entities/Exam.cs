using System;
using Database.Entities;

namespace Business.Entities
{
    public class Exam
    {
        public int _Id { get; private set; }
        public DateTime DataExame { get; set; }
        public int Glicemia { get; set; }
        public int DosePrincipal { get; set; }
        public int DoseSecundaria { get; set; }


        public Exam()
        {
        }

        public Exam(int id, DateTime dataExame, int glicemia, int dosePrincipal, int doseSecundaria)
        {
            _Id = id;
            DataExame = dataExame;
            Glicemia = glicemia;
            DosePrincipal = dosePrincipal;
            DoseSecundaria = doseSecundaria;
        }

        public void NewExam()
        {
            DataQueries data = new DataQueries();
            data.InsertExam(_Id, DataExame, Glicemia, DosePrincipal, DoseSecundaria);
        }

        public int ShowNextId()
        {
            DataQueries data = new DataQueries();
            return data.GetIdNumber() + 1;
        }
    }
}