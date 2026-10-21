namespace pcrespoS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();

		DisplayAlertAsync("Bienvenido", usuario, "Cerrar");
		lblUsuario.Text = "Usuario COnectado"+usuario;
	}
}