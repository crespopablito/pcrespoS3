namespace pcrespoS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private async void btnGuardarUsuario_Clicked(object sender, EventArgs e)
    {
        string usuarioNuevo=txtUsuarioNuevo.Text;
        string contrasenaNueva=txtContra.Text;

        await Navigation.PushAsync(new vlogin(usuarioNuevo, contrasenaNueva));
        await DisplayAlertAsync("OJO", "Usuario Guardado", "continuar");

    }

    private async void btnCancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new vlogin());
    }
}