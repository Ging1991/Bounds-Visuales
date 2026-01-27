using UnityEngine;

namespace Bounds.Visuales {

	public class ContadorCarta : Contador {

		public override void SetTipo(string tipo) {
			if (tipo == "debilidad") {
				icono.SetColorFuente(Color.white);
				icono.SetDimensiones(100, 100);
				icono.SetImagen(imgSangre);
			}
			if (tipo == "supervivencia") {
				icono.SetColorFuente(Color.black);
				icono.SetDimensiones(70, 60);
				icono.SetImagen(imgEscudo);
			}
			if (tipo == "veneno") {
				icono.SetColorFuente(Color.magenta);
				icono.SetDimensiones(70, 75);
				icono.SetImagen(imgVeneno);
			}
			if (tipo == "poder") {
				icono.SetColorFuente(Color.blue);
				icono.SetDimensiones(65, 60);
				icono.SetImagen(imgCristal);
			}
			if (tipo == "mision") {
				icono.SetColorFuente(Color.blue);
				icono.SetDimensiones(65, 60);
				icono.SetImagen(imgCristal);
			}
		}

	}

}