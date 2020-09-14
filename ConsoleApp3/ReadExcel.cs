using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ReadExcel
    {
        //SpreadSheet CLASS TO READ AN EXCEL FILE 
        SLDocument mDocument;
        int rowStarts;
        List<Alumno> alumnos = new List<Alumno>();

        public ReadExcel(string path, int rowStarts)
        {
            //JUST FOR SEE THE PATH
            Console.WriteLine(path);
            mDocument = new SLDocument(path);
            this.rowStarts = rowStarts; 
        }

        public List<Alumno> readCells()
        {
           
            while (!string.IsNullOrEmpty(mDocument.GetCellValueAsString(rowStarts, 1)))
            {
                
                int numberControl =  mDocument.GetCellValueAsInt32(rowStarts, 1);
                string name = mDocument.GetCellValueAsString(rowStarts, 2);
                string surname = mDocument.GetCellValueAsString(rowStarts, 3);
                string secondSurname = mDocument.GetCellValueAsString(rowStarts, 4);
                string career = mDocument.GetCellValueAsString(rowStarts, 5);
                string unit = mDocument.GetCellValueAsString(rowStarts, 6);
                string gender = "Masculino"; 
                
                alumnos.Add(new Alumno(numberControl, name, surname, secondSurname, unit, new Carrera(career), new Genero(gender)));

               
                rowStarts++;
            }
            
            Console.WriteLine($"rows={this.rowStarts}");

                  
            return alumnos;
        }


        

    }
}
