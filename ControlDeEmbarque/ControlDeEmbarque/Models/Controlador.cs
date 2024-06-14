namespace ControlDeEmbarque.Models
{
    public class Controlador
    {
        const int tamanio = 1000;
        public int[] idContenedor = new int[tamanio];
        public string[] paisorg = new string[tamanio];
        public double[] pesoc = new double[tamanio];
        public int cont = 0;
        public int[] pocision = new int[tamanio];
        public void AgregarContenedor(int id, string pais,double peso)
        {
                idContenedor[cont] = id;
                paisorg[cont] = pais;
                pesoc[cont] = peso;
                cont++;
        }
        public int[] BuscarPorOrigen(string buscado, ref  int cant)
        {
           for(int i = 0; i < cont; i++)
            {
                if (paisorg[i] == buscado)
                {
                    pocision[cant] = i;
                    cant++;
                }
            }
            return pocision; 
        }
        public void Burbuja()
        {
            int i = 0, j = 0, aux1 = 0;
            double aux2 = 0;
            string aux3 = "";
            for(i = 0; i < cont; i++)
            {
                for(j = i + 1;j< cont; j++)
                {
                    if (idContenedor[i] > idContenedor[j])
                    {
                        aux1 = idContenedor[i];
                        idContenedor[i] = idContenedor[j];
                        idContenedor[j] = aux1;

                        aux2 = pesoc[i];
                        pesoc[i] = pesoc[j];
                        pesoc[j] = aux2;

                        aux3 = paisorg[i];
                        paisorg[i] = paisorg[j];
                        paisorg[j] = aux3;
                    }
                }
            }
        }
    }
}
