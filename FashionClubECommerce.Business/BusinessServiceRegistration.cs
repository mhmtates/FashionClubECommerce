using FashionClubECommerce.Business.Abstract;
using FashionClubECommerce.Business.Concrete;
using FashionClubECommerce.Business.ValidationRules.FluentValidation;
using FashionClubECommerce.DataAccess.Abstract;
using FashionClubECommerce.DataAccess.Concrete;
using FashionClubECommerce.DataAccess.Concrete.Contexts.EntityFramework;
using FashionClubECommerce.Entities.Dto.DtoCategory;
using FashionClubECommerce.Entities.Dto.DtoCustomer;
using FashionClubECommerce.Entities.Dto.DtoOrder;
using FashionClubECommerce.Entities.Dto.DtoOrderDetail;
using FashionClubECommerce.Entities.Dto.DtoOrderInformation;
using FashionClubECommerce.Entities.Dto.DtoOrderNote;
using FashionClubECommerce.Entities.Dto.DtoProduct;
using FashionClubECommerce.Entities.Dto.DtoProductImage;
using FashionClubECommerce.Entities.Dto.DtoSlide;
using FashionClubECommerce.Entities.Dto.DtoUserAdmin;
using FashionClubECommerce.Entities.Dto.DtoVariant;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace FashionClubECommerce.Business
{
    public static class  BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddDbContext<FashionContext>();
            services.AddScoped<IUnitOfWorks, UnitOfWorks>();
            services.AddScoped<IProductsService, ProductsManager>();
            services.AddScoped<ICategoriesService, CategoriesManager>();
            services.AddScoped<ICustomersService, CustomersManager>();
            services.AddScoped<IOrdersService, OrdersManager>();
            services.AddScoped<IUsersAdminService, UserAdminManager>();
            services.AddScoped<IProductImagesService, ProductImagesManager>();
            services.AddScoped<IVariantsService, VariantsManager>();
            services.AddScoped<ITemporaryBasketsService, TemporaryBasketsManager>();
            services.AddScoped<IOrderDetailsService, OrderDetailsManager>();
            services.AddScoped<IOrderInformationsService, OrderInformationsManager>();
            services.AddScoped<ISlidesService, SlidesManager>();
            services.AddSingleton<IValidator<CategoriesDto>, CategoriesValidation>();
            services.AddSingleton<IValidator<CustomersUpdateDto>, CustomersValidation>();
            services.AddSingleton<IValidator<OrderInformationsDto>, OrderInformationsValidation>();
            services.AddSingleton<IValidator<OrderNotesDto>, OrderNotesValidation>();
            services.AddSingleton<IValidator<OrderDetailsDto>, OrderDetailsValidation>();
            services.AddSingleton<IValidator<OrdersUpdateDto>, OrdersValidation>();
            services.AddSingleton<IValidator<ProductImagesDto>, ProductImagesValidation>();
            services.AddSingleton<IValidator<ProductsUpdateDto>, ProductsValidation>();
            services.AddSingleton<IValidator<UsersAdminDto>, UsersAdminValidation>();
            services.AddSingleton<IValidator<VariantsDto>, VariantsValidation>();
            services.AddSingleton<IValidator<SlidesDto>, SlidesValidation>();
            return services;
        }

    }
}
