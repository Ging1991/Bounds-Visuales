using System.Collections.Generic;
using Ging1991.Core;
using UnityEngine;

namespace Bounds.Visuales {

	public class GestorVisual : MonoBehaviour {

		public List<Visual> visuales;
		public GestorDeSonidos gestorDeSonidos;

		public void Animar(string codigo, string sonido) {
			foreach (var visual in visuales) {
				if (visual.codigo == codigo) {
					visual.gameObject.SetActive(true);
					visual.Iniciar();
					if (sonido != "" && gestorDeSonidos != null) {
						gestorDeSonidos.ReproducirSonido(sonido);
					}
					break;
				}
			}
		}

	}

}