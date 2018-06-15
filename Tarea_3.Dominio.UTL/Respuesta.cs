using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.Dominio.UTL
{
    public partial class Respuesta<T>
    {
        public Boolean bnlIndicadorTransaccion = true;
        public EMessageType enuTipoMensaje;
        public String strMensajeRespuesta = "¡Transacción realizada exitosamente!";
        public String strOrigen = String.Empty;
        public int resultado;
        public T valorRetorno;
    }//Fin de la clase Respuesta.

    #region "Enums"
    public enum EMessageType
    {
        eNone = 0,
        eValidation = 1,
        eInformative = 2,
        eError = 3,
        eRequest = 4
    }
    #endregion

}



