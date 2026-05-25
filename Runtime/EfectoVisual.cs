using Ging1991.Core.Interfaces;
using Ging1991.Musica;
using UnityEngine;

namespace Bounds.Visuales {

	public abstract class EfectoVisual : MonoBehaviour {

		public string codigo;
		public string sonido;
		protected GestorDeSonidos gestorDeSonidos;

		public void Inicializar(GestorDeSonidos gestorDeSonidos) {
			this.gestorDeSonidos = gestorDeSonidos;
		}


		public abstract void Activar();


		public class AccionDesactivar : IEjecutable {

			private readonly GameObject objeto;

			public AccionDesactivar(GameObject objeto) {
				this.objeto = objeto;
			}

			public void Ejecutar() {
				objeto.SetActive(false);
			}
		}


	}

}