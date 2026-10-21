namespace pcrespoS3.Views;

public partial class vlogin : ContentPage
{
    string usuario = "";
    string contrasena = "";
	public vlogin()
	{
		InitializeComponent();
	}
    public vlogin(string UsuarioNuevo, string ContrasenaNueva)
    {
        InitializeComponent();
		usuario = UsuarioNuevo;
		contrasena=ContrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioingresado = txtUsuario.Text;
			string contrasenaIngresada = txtContra.Text;
			if (usuario==usuarioingresado && contrasena==contrasenaIngresada)
			{
				await Navigation.PushAsync(new Views.vPrincipal(usuario));
			}
			else
			{
				await DisplayAlertAsync("ERROR", "usuario o contra incorrectos", "cerrar");
				txtUsuario.Text = "";
				txtContra.Text = "";
			}
		}
		catch (Exception ex)
		{

            await DisplayAlertAsync("ERROR", ex.Message, "cerrar");
        }
    }


    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.vRegistro());
    }
}