using System.Collections.Generic;
using Ging1991.Musica;
using UnityEngine;

namespace Bounds.Visuales {

	public class GestorEfectosVisuales : MonoBehaviour {

		public List<EfectoVisual> visuales;

		public void Inicializar(GestorDeSonidos gestorDeSonidos) {
			foreach (var visual in visuales) {
				visual.Inicializar(gestorDeSonidos);
			}
		}


		public void Animar(string codigo) {
			EfectoVisual objetivo = null;
			foreach (var visual in visuales) {
				if (visual.codigo == codigo) {
					objetivo = visual;
					break;
				}
			}
			if (objetivo != null) {
				objetivo.gameObject.SetActive(true);
				objetivo.Activar();
			}
			else {
				Debug.LogWarning($"No se encontro la animación {codigo}");
			}
		}

	}

}