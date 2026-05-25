using Ging1991.Animaciones.Efectos;

namespace Bounds.Visuales {

	public class EfectoExplosion : EfectoVisual {

		public Escalar escalar;
		public Rotar rotar;
		public Trasparentar trasparentar;

		public override void Activar() {
			trasparentar.accionFinal = new AccionDesactivar(gameObject);
			gestorDeSonidos.ReproducirSonido(sonido);

			escalar.Inicializar();
			rotar.Inicializar();
			trasparentar.Inicializar();
		}


	}

}