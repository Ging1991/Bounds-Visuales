using System.Collections.Generic;
using UnityEngine;

namespace Bounds.Visuales {

	public class GestorContadores : MonoBehaviour {

		public GameObject claseContador;
		private readonly Dictionary<string, GameObject> contadores = new();
		public int xInicial;
		public int yInicial;
		public int salto;


		public void SetContador(string tipo, int cantidad) {
			if (cantidad == 0) {
				EliminarIcono(tipo);
				return;
			}
			CrearSiNoExiste(tipo).GetComponent<Contador>().SetCantidad(cantidad);
			Organizar();
		}


		private void EliminarIcono(string tipo) {
			if (contadores.ContainsKey(tipo)) {
				GameObject contador = contadores[tipo];
				contadores.Remove(tipo);
				Destroy(contador);
			}
		}


		private Contador CrearSiNoExiste(string tipo) {

			if (!contadores.ContainsKey(tipo)) {
				GameObject instancia = Instantiate(claseContador);
				instancia.transform.SetParent(transform);
				instancia.transform.localRotation = Quaternion.Euler(0, 0, 0);
				instancia.GetComponent<Contador>().SetTipo(tipo);
				contadores.Add(tipo, instancia);
			}
			return contadores[tipo].GetComponent<Contador>();
		}


		private void Organizar() {
			foreach (var contador in contadores.Values) {
				contador.transform.localPosition = new Vector3(xInicial, yInicial - contadores.Keys.Count * salto, 0);
			}
		}

	}

}