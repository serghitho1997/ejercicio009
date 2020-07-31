using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datos;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace UTDatos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Raiz r = new Raiz();
            r.Otro = new Class2();
            r.Otro.Tercero = new Class3();

            Assert.IsNotNull(r);
            Assert.IsNotNull(r.Otro);
            Assert.IsNotNull(r.Otro.Tercero);
        }

        [TestMethod]
        public void TestListVarios()
        {
            IList<string> listadeEjemplo = new List<string>();

            IList otraLista = new List<object>();
            otraLista.Add("Hola");
            otraLista.Add(new Raiz());

            object a = "Hola";
            a = new Raiz();
            string hola = (string)a;
            listadeEjemplo.Add(" Mensaje ");
            //listadeEjemplo.Add(new Raiz());
            string todos = "";
            for (int i = 0; i < listadeEjemplo.Count; i++)
            {
                string mensajes = listadeEjemplo[i];
                listadeEjemplo.Remove(mensajes);
                todos += mensajes;
            }
            todos = "";
            foreach (string mensajes in listadeEjemplo)
            {
                todos += mensajes;

            }
            string primero = listadeEjemplo
                       .Select(x => x.Trim())
                       .Where(x => x.StartsWith("Mensaje"))
                       .First();
        }
        [TestMethod]

        public void TestSet()
        {
            ISet<string> miConjunto = new HashSet<string>();
            string cadena1 = "Mensaje";
            string cadena2 = new string("Mensaje");
            miConjunto.Add(cadena1);
            Assert.IsTrue(miConjunto.Contains("Mensaje"));
            ISet<object> miConjunto2 = new HashSet<object>();
            Raiz raiz1 = new Raiz() { ID = 5 };
            Raiz raiz2 = new Raiz() { ID = 5, Otro = new Class2() };
            miConjunto2.Add(new Raiz());
            Assert.IsTrue(miConjunto2.Contains(new Raiz()));
            int total = 0;
            foreach (Raiz r in miConjunto2)
            {
                total += r.ID;
            }
            IEnumerator<Raiz> enumeracion = (IEnumerator<Raiz>)miConjunto2.GetEnumerator();
            int total2 = 0;
            while (enumeracion.MoveNext())
            {
                Raiz r = enumeracion.Current;
                total2 += r.ID;
            }

            Assert.AreEqual(total, total2);
            int total3 = miConjunto2
                //.Select(r => r.ID).Sum();
            Assert.AreEqual(total, total3);

        }
        [TestMethod]

    public void Ejercicio()
        {

            IList<string> listaEjercicio = new List<string>();
            listaEjercicio.Add("cadena1");
            listaEjercicio.Add("cadena2");
            listaEjercicio.Add("cadena3");
            listaEjercicio.Add("cadena4");
            listaEjercicio.Add("cadena5");
            int x;
            string todos = "";
            for (x = 0; x < listaEjercicio.Count; x++)
            {
                string cadena = listaEjercicio[x];
                
            }
            
                

        }
    }
}