using Ging1991.Interfaces.Salida;
using UnityEngine;

namespace Bounds.Visuales {

	public abstract class Contador : MonoBehaviour {

		public Sprite imgVeneno;
		public Sprite imgCristal;
		public Sprite imgSangre;
		public Sprite imgEscudo;
		public ContadorIcono icono;

		public abstract void SetTipo(string tipo);

		public void SetCantidad(int cantidad) {
			icono.SetValor(cantidad);
		}

	}

}