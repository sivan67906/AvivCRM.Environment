using Microsoft.EntityFrameworkCore;
using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Infrastructure.Persistence;

public class EnvironmentDbContext(DbContextOptions<EnvironmentDbContext> options)
    : DbContext(options)
{

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new ConsumerSeedData());
        modelBuilder.Entity<Applications>().Navigation(e => e.Currency).AutoInclude();
        modelBuilder.Entity<ProjectSetting>().Navigation(e => e.ProjectReminderPerson).AutoInclude();
        modelBuilder.Entity<RecruitCustomQuestionSetting>().Navigation(e => e.CustomQuestionType).AutoInclude();
        modelBuilder.Entity<RecruitCustomQuestionSetting>().Navigation(e => e.CustomQuestionCategory).AutoInclude();
        modelBuilder.Entity<RecruitJobApplicationStatusSetting>().Navigation(e => e.JobApplicationPosition).AutoInclude();
        modelBuilder.Entity<RecruitJobApplicationStatusSetting>().Navigation(e => e.JobApplicationCategory).AutoInclude();
        modelBuilder.Entity<TimeLog>().Navigation(e => e.role).AutoInclude();
        modelBuilder.Entity<Company>().Navigation(e => e.BusinessType).AutoInclude();
        modelBuilder.Entity<Company>().Navigation(e => e.Category).AutoInclude();
        modelBuilder.Entity<Department>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<Designation>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<Designation>().Navigation(e => e.Department).AutoInclude();
        modelBuilder.Entity<Role>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<Role>().Navigation(e => e.Department).AutoInclude();
        modelBuilder.Entity<Role>().Navigation(e => e.Designation).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.Company).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.Address).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.Country).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.State).AutoInclude();
        modelBuilder.Entity<BusinessLocation>().Navigation(e => e.City).AutoInclude();
        modelBuilder.Entity<FinanceInvoiceSetting>().Navigation(e => e.Language).AutoInclude();
        modelBuilder.Entity<TimesheetSetting>().Navigation(e => e.projectSetting).AutoInclude();
    }
    public DbSet<LeadStatus> LeadStatuses { get; set; }
    public DbSet<LeadSource> LeadSources { get; set; }
    public DbSet<LeadAgent> LeadAgents { get; set; }
    public DbSet<LeadCategory> LeadCategories { get; set; }
    public DbSet<Applications> Applications { get; set; }
    public DbSet<Planning> Plannings { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Domain.Entities.Task> Tasks { get; set; }
    public DbSet<Tax> Taxes { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<ProjectCategory> ProjectCategories { get; set; }
    public DbSet<ProjectStatus> ProjectStatuses { get; set; }
    public DbSet<ProjectSetting> ProjectSettings { get; set; }
    public DbSet<ProjectReminderPerson> ProjectReminderPersons { get; set; }
    public DbSet<CustomQuestionCategory> CustomQuestionCategories { get; set; }
    public DbSet<CustomQuestionType> CustomQuestionTypes { get; set; }
    public DbSet<JobApplicationCategory> JobApplicationCategories { get; set; }
    public DbSet<JobApplicationPosition> JobApplicationPositions { get; set; }
    public DbSet<RecruitCustomQuestionSetting> RecruitCustomQuestionSettings { get; set; }
    public DbSet<RecruiterSetting> RecruiterSettings { get; set; }
    public DbSet<RecruitFooterSetting> RecruitFooterSettings { get; set; }
    public DbSet<RecruitGeneralSetting> RecruitGeneralSettings { get; set; }
    public DbSet<RecruitJobApplicationStatusSetting> RecruitJobApplicationStatusSettings { get; set; }
    public DbSet<RecruitNotificationSetting> RecruitNotificationSettings { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BusinessType> BusinessTypes { get; set; }
    public DbSet<BusinessLocation> BusinessLocations { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Client> clients { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<TimeLog> TimeLogs { get; set; }
    public DbSet<NotificationMain> NotificationMains { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<FinanceInvoiceSetting> FinanceInvoiceSettings { get; set; }
    public DbSet<FinanceInvoiceTemplateSetting> FinanceInvoiceTemplateSettings { get; set; }
    public DbSet<FinancePrefixSetting> FinancePrefixSettings { get; set; }
    public DbSet<FinanceUnitSetting> FinanceUnitSettings { get; set; }
    public DbSet<TimesheetSetting> TimesheetSettings { get; set; }

    public DbSet<BillOrder> BillOrders { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<VendorCredit> VendorCredit { get; set; }
    public DbSet<Employee> Employees { get; set; }
}