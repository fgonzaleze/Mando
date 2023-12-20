
namespace Entities
{
    public class clsMision
    {
        #region Atributos

        private int id;
        private String nombreMision;
        private String detallesMision;
        private double creditos;

        #endregion
        #region Constructores
        public clsMision() { }

        public clsMision(int id, string nombreMision, string detallesMision, double creditos)
        {
            this.id = id;
            this.nombreMision = nombreMision;
            this.detallesMision = detallesMision;
            this.creditos = creditos;
        }

        #endregion
        #region Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String NombreMision
        {
            get { return nombreMision; }
            set { nombreMision = value; }
        }
        public String DetallesMision
        {
            get { return detallesMision; }
            set { detallesMision = value; }
        }
        public double Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        #endregion

    }
}
