using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace TP12_2COFRELUCAS.Modelo
{
    class ModeloFab
    {
        public string Modelo { get; set; }
        public string StockIni { get; set; }
        public string CantPedida { get; set; }

        public string StockFinal { get; set; }
        public string AFabricar { get; set; }
        public string SeAdeudan { get; set; }

        public List<ModeloFab> ListModelo { get; set; }

        public ModeloFab ()
        {

        }

        public ModeloFab (Modelo.Pedidos objP, Modelo.Stock objS,Modelo.StockPiezas objSP,Modelo.Composicion objC, Modelo.SeAdeudan[] objSA)
        {
            ListModelo = new List<ModeloFab>();
            ModeloFab obj;
            string busqCP; 
            int cant = objS.stc.Count();
            int stockf;
            for (int i = 0; i < cant; i++)
            {
                obj = new ModeloFab();
                obj.Modelo = objS.stc[i].NModelo;
                obj.StockIni = Convert.ToString(objS.stc[i].stock);
                //
                //
                busqCP = obj.Modelo; //envio el numero de modelo a otro objeto para buscar otro dato relacionado(este caso, cant pedida)
                obj.CantPedida = EncuentraPedidos(objP,busqCP);
                //
                //
                stockf = int.Parse(obj.StockIni) - int.Parse(obj.CantPedida);
                if (stockf < 0)
                {
                    obj.StockFinal = "0";
                    obj.AFabricar = Convert.ToString(stockf * (-1));
                }
                else
                {
                    obj.StockFinal = Convert.ToString(stockf);
                }
                string busqueda = obj.Modelo;
                obj.SeAdeudan = Convert.ToString(EncuentraLinq(busqueda, objSA));
                ListModelo.Add(obj);

            }
        }
        string EncuentraLinq(string obj, SeAdeudan[] objSA)
        {
            string devuelve = null;
            IEnumerable<Modelo.SeAdeudan> BuscoModParaCuantosAdeudo = from busk in objSA where busk.NModelo == obj select busk;
            foreach (SeAdeudan de in BuscoModParaCuantosAdeudo)
            {
                devuelve = de.CantAdeud.ToString();
            }

            return devuelve;
        }


        string EncuentraPedidos(Modelo.Pedidos objP, string busq)
        {
            string busqf = null;
            if (objP.Mod != null)
            {
                IEnumerable<Pedidos> buscocant = from pedid in objP.Mod where pedid.NModelo == busq select pedid;
                foreach (Pedidos pe in buscocant)
                {
                    if (pe.NModelo == busq)
                    {
                        busqf = pe.CantPedida;
                    }
                }
            }

            return busqf;
        }

    }

    class Piezas
    {
        public string Pieza { get; set; }
        public string StockIni { get; set; }
        public string StockFinal { get; set; }
        public string CantMinima { get; set; }
        public List<Piezas> ListPieza { get; set; }

        public Piezas()
        {

        }

        public Piezas(Modelo.Pedidos objP, Modelo.Stock objS, Modelo.StockPiezas objSP, Modelo.Composicion objC, Modelo.SeAdeudan[] objSA)
        {
            ListPieza = new List<Piezas>();
            const int tam = 20;
            int[] pimo = new int[tam];
            Piezas obj;
            string busq;
            bool bandera2=true;
            //int cant = objSP.stcp.Count();
            int stockf;
            int cont =0;
            string[] busqf = new string [3];
            for (int k = 0; k<40; k++)
            {
                List<int> autos = new List<int>();
                while (bandera2 == true)
                {
                    for (int i = 0; i < tam; i++)
                    {


                        obj = new Piezas();
                        obj.Pieza = objSP.stcp[i].NroPieza;
                        if (Convert.ToInt32(objSP.stcp[i].Stock) >= 0)
                        {
                            obj.StockIni = objSP.stcp[i].Stock;
                        }

                        //


                        busq = objSP.stcp[i].NroPieza;
                        EncuentraPieza(objC, busq, busqf);
                        obj.StockFinal = Convert.ToString(Convert.ToInt32(busqf[2]) - Convert.ToInt32(obj.StockIni));

                        //

                        if (int.Parse(obj.StockFinal) < 0)
                        {
                            obj.CantMinima = Convert.ToString(int.Parse(obj.StockFinal) * (-1));
                            obj.StockFinal = "0";
                            bandera2 = false;

                        }
                        else
                        {
                            obj.CantMinima = "0";
                            bandera2 = true;
                        }
                        ListPieza.Add(obj);
                        if (bandera2 == true)
                        {
                            cont++;
                        }

                        double cantautos = Math.Truncate(Convert.ToDouble(obj.StockIni) / Convert.ToDouble(obj.CantMinima)  )  ;
                        double sobrentes = double.Parse(obj.StockIni) % double.Parse(obj.CantMinima);
                        autos.Add(Convert.ToInt32(cantautos));





                    }
                }
                objSA[k] = new SeAdeudan();
                objSA[k].NModelo = busqf[0];
                objSA[k].CantAdeud = autos.Min();//para cada modelo, la cantidad minima de autos que puedo fabricar de las 200 piezas, sera la cantidad minima de autos que puedo fabricar con lo que tengo
            }
            
                
        }


        void EncuentraPieza(Modelo.Composicion objC, string busq, string[] busqf)
        {
            busqf = new string[3];
            if (objC.Com != null)
            {
                IEnumerable<Composicion> buscopieza = from comp in objC.Com where comp.NPieza == busq select comp;
                foreach (Composicion co in buscopieza)
                {
                    if (co.NPieza == busq)
                    {
                        busqf[0] = co.NModelo;
                        busqf[1] = co.NPieza;
                        busqf[2] = co.CantUsar;
                    }
                }
            }

            return;
        }
    }

    public class SeAdeudan
    {
        public string NModelo { get; set; }
        public int CantAdeud { get; set; }
    }
}
