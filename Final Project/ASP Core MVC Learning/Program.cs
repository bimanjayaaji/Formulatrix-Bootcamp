namespace FirstCoreMVCWebApp;

public class Program
{
	static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		// Add MVC services to the container.
		builder.Services.AddMvc();
		var app = builder.Build();
		app.UseRouting();
		app.UseEndpoints(endpoints =>
		{
			//Configuring the MVC middleware to the request processing pipeline
			endpoints.MapDefaultControllerRoute();
		});
		app.Run();
		
		/* go here:
		 * http://localhost:<portnumber>/Home/GetStudentDetails/103
		 */
	}
	
	static void Main1(string[] args) //* template
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddControllersWithViews();

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();
	}
}

