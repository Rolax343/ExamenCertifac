using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Addendas
    {
        public static ML.Result AddendaGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.Cer_AddendasEntities context = new DL.Cer_AddendasEntities())
                {
                    var tableAddendas = context.AddendaGetAll().ToList();

                    if (tableAddendas.Count > 0)
                    {
                        foreach (var row in tableAddendas)
                        {
                            ML.Addenda addenda = new ML.Addenda();
                            addenda.IdAddenda = row.IdAddenda;
                            addenda.NombreAddenda = row.nombreAddenda;
                            addenda.XML = row.XML;
                            addenda.FechaModificacion = Convert.ToString(row.FechaModificacion);
                            addenda.Usuario = row.Usuario;
                            addenda.Estado = row.Estado.Value;
                            result.Objects.Add(addenda);
                        }
                        result.Correct = true;
                    } else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo recuperar los registros";
                    }
                }
            }
            catch (Exception e) 
            {
                result.Correct = false;
                result.Ex = e;
                result.ErrorMessage = e.Message;
            }
            return result;
        }
    }
}
