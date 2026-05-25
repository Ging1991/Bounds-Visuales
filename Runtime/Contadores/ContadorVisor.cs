using UnityEngine;

namespace Bounds.Visuales {

	public class ContadorVisor : Contador {

		public override void SetTipo(string tipo) {
			if (tipo == "debilidad") {
				icono.SetColorFuente(Color.white);
				icono.SetDimensiones(140, 140);
				icono.SetImagen(imgSangre);
			}
			if (tipo == "supervivencia") {
				icono.SetColorFuente(Color.black);
				icono.SetDimensiones(100, 90);
				icono.SetImagen(imgEscudo);
			}
			if (tipo == "veneno") {
				icono.SetColorFuente(Color.magenta);
				icono.SetDimensiones(100, 90);
				icono.SetImagen(imgVeneno);
			}
			if (tipo == "poder") {
				icono.SetColorFuente(Color.blue);
				icono.SetDimensiones(100, 90);
				icono.SetImagen(imgCristal);
			}
			if (tipo == "mision") {
				icono.SetColorFuente(Color.blue);
				icono.SetDimensiones(100, 90);
				icono.SetImagen(imgCristal);
			}
		}

	}

}