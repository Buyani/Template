using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReflectionIT.Mvc.Paging;
using Template.Business.AccountBusiness;
using Template.Business.EnrollementBusiness;
using Template.Business.FormerSchoolBusiness;
using Template.Business.GuardianBusiness;
using Template.Business.PaymentBusiness;
using Template.Business.StudentBusiness;
using Template.Business.SubjectBusiness;
using Template.Data;
using Template.Model;
using Template.Service.EnrollementService;
using Template.Service.GuardianService;
using Template.Service.PaymentService;
using Template.Service.SchoolService;
using Template.Service.StudentService;
using Template.Service.SubjectService;

namespace Template
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            //register services here
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IPaymentRepository, PaymentRepository>();
            services.AddTransient<ISchoolRepository, SchoolRerpository>();
            services.AddTransient<IEnrollementRepository, EnrollementRepository>();
            services.AddTransient<IGuardianRepository, GuardianRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();


            //Business Logis registration services
            services.AddTransient<IStudentBusinessLogic, StudentBusinessLogic>();
            services.AddTransient<ISchoolBusinessLogic, SchoolBusinessLogic>();
            services.AddTransient<ISubjectbusinessLogic, SubjectbusinessLogic>();
            services.AddTransient<IPaymentBusinessLogic, PaymentBusinessLogic>();
            services.AddTransient<IEnrollementBusinessLogic, EnrollementBusinessLogic>();
            services.AddTransient<IGuardianBusinessLogic, GuardianBusinessLogic>();


            services.AddTransient<IRegisterBusiness, RegisterBusiness>();
            services.AddTransient< ILogInBusiness,LogInBusiness>();
            //*
            services.AddDbContext<MatricExcellenceDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<MatricExcellenceDbContext>();

            services.Configure<PasswordHasherOptions>(options =>
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3);

            services.AddControllersWithViews();
            services.AddPaging();

            // requires:
            // using AspNetCoreEmailConfirmationSendGrid.Services;
            // using Microsoft.AspNetCore.Identity.UI.Services;
            services.AddTransient<IEmailSender, EmailSender>();


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/account/login";
                options.LogoutPath = $"/account/logout";
                options.AccessDeniedPath = $"/account/accessDenied";
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Student}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
