using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Peyman.Model.Account;
using Peyman.Model.Definition;
using Peyman.Model.Form;
using Peyman.Model.Setting;
using Peyman.Model.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peyman.DAL.Context
{
    public static class DataSeeding
    {
        public async static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<PeymanContext>();
            context.Database.Migrate();

            //#region ChemicalSeed GÜNCELLENDİ
            //if (context.Chemicals.Count() == 0)
            //{
            //    context.Chemicals.AddRange(
            //        new List<Chemical>()
            //        {
            //            new Chemical(){Name = "Stomp Extra", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Chemical(){Name = "Challenge SC600", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Chemical(){Name = "Zamir", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Chemical(){Name = "Azimut", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Chemical(){Name = "Quadris Max", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //        }
            //        );
            //   context.SaveChanges();
            //}
            //#endregion


            //#region DOFCheckProblemSeed GÜNCELLENDİ
            //if (context.DOFCheckProblems.Count() == 0)
            //{
            //    context.DOFCheckProblems.AddRange(
            //        new List<DOFCheckProblem>()
            //        {
            //            new DOFCheckProblem(){Name = "Çıkış Problemi", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new DOFCheckProblem(){Name = "Böcek Zararı", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new DOFCheckProblem(){Name = "Mantar Enfeksiyonları", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new DOFCheckProblem(){Name = "Su Hatası", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new DOFCheckProblem(){Name = "Ekim Hatası", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region DOFPreventiveActionSeed GÜNCELLENDİ
            //if (context.DOFPreventiveActions.Count() == 0)
            //{
            //    context.DOFPreventiveActions.AddRange(
            //        new List<DOFPreventiveAction>()
            //        {
            //            new DOFPreventiveAction(){Name = "Tarla Bozdurma", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new DOFPreventiveAction(){Name = "İnsektisit Kullanımı", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new DOFPreventiveAction(){Name = "Fungisit Kullanımı", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now}
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region RegionSeed GÜNCELLENDİ
            //if (context.Regions.Count() == 0)
            //{
            //    context.Regions.AddRange(
            //        new List<Region>()
            //        {
            //            new Region(){Name = "Karapınar", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Region(){Name = "Çumra", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Region(){Name = "Karaman", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Region(){Name = "Amasya", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Region(){Name = "Tokat", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region SupplierSeed GÜNCELLENDİ
            //if (context.Suppliers.Count() == 0)
            //{
            //    context.Suppliers.AddRange(
            //        new List<Supplier>()
            //        {
            //            new Supplier(){Name = "Kesikler Tarım", AddedBy = "Admin", Email = "beyazit95@gmail.com", PhoneNumber = "54236611232", IsActive = true},
            //            new Supplier(){Name = "Targi", AddedBy = "Admin", Email = "asimbakim@gmail.com", PhoneNumber = "54266611532", IsActive = true},
            //            new Supplier(){Name = "Türkoğlu Tarım", AddedBy = "Admin", Email = "beylertarim@gmail.com", PhoneNumber = "54236624232", IsActive = true},
            //            new Supplier(){Name = "Ramazan Turan", AddedBy = "Admin", Email = "elittarim@gmail.com", PhoneNumber = "542366112232", IsActive = true},
            //            new Supplier(){Name = "Hasan Elibol", AddedBy = "Admin", Email = "belugatarim@gmail.com", PhoneNumber = "54234615232", IsActive = true},
            //            new Supplier(){Name = "Özsel Agro", AddedBy = "Admin", Email = "elittarim@gmail.com", PhoneNumber = "542366112232", IsActive = true},

            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region SupplierEmployeeSeed GÜNCELLENDİ
            //if (context.SupplierEmployees.Count() == 0)
            //{
            //    context.SupplierEmployees.Add(new SupplierEmployee() { FirstName = "Emre", LastName = "Kesik", SupplierId = 1, AddedBy = "Admin", Email = "emrekesik@gmail.com", PhoneNumber = "54236611232", IsActive = true });


            //    context.SupplierEmployees.AddRange(
            //        new List<SupplierEmployee>()
            //        {
            //            //new SupplierEmployee(){FirstName = "Emre", LastName = "Kesik", SupplierId = 1, AddedBy = "Admin", Email = "emrekesik@gmail.com", PhoneNumber = "54236611232", IsActive = true},
            //            new SupplierEmployee(){FirstName = "Sedat", LastName = "Berber", SupplierId = 2, AddedBy = "Admin", Email = "sedatberber@gmail.com", PhoneNumber = "54236611233", IsActive = true},
            //            new SupplierEmployee(){FirstName = "Okan", LastName = "Türkoğlu", SupplierId = 3, AddedBy = "Admin", Email = "okanturkoglu@gmail.com", PhoneNumber = "54236611234", IsActive = true},
            //            new SupplierEmployee(){FirstName = "Ramazan", LastName = "Turan", SupplierId = 4, AddedBy = "Admin", Email = "ramazanturan@gmail.com", PhoneNumber = "54236611235", IsActive = true},
            //            new SupplierEmployee(){FirstName = "Hasan", LastName = "Elibol", SupplierId = 5, AddedBy = "Admin", Email = "hasanturan@gmail.com", PhoneNumber = "54236611236", IsActive = true},
            //            new SupplierEmployee(){FirstName = "Özer", LastName = "Ozan", SupplierId = 6, AddedBy = "Admin", Email = "ozeronen@gmail.com", PhoneNumber = "54236611237", IsActive = true}
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region IrrigationSeed GÜNCELLENDİ
            //if (context.Irrigations.Count() == 0)
            //{
            //    context.Irrigations.AddRange(
            //        new List<Irrigation>()
            //        {
            //            new Irrigation(){Name = "Damlama Sistemi", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Irrigation(){Name = "Yağmurlama Sistemi", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Irrigation(){Name = "Pivot Sulama", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Irrigation(){Name = "Salma Sulama", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region HoeingSeed
            //if (context.Hoeings.Count() == 0)
            //{
            //    context.Hoeings.AddRange(
            //        new List<Hoeing>()
            //        {
            //            new Hoeing(){Name = "Eltos Çapa", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Hoeing(){Name = "Aktepe Çapa", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Hoeing(){Name = "Demiray Çapa", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Hoeing(){Name = "Ennalbur Çapa", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Hoeing(){Name = "Fiskars Çapa", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region EquipmentSeed
            //if (context.Equipments.Count() == 0)
            //{
            //    context.Equipments.AddRange(
            //        new List<Equipment>()
            //        {
            //            new Equipment(){Name = "Su Tankeri", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Equipment(){Name = "Traktör Sepeti", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Equipment(){Name = "Römork", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Equipment(){Name = "Biçerdöver Makinesi", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Equipment(){Name = "Yükleme Makinesi", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},

            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            #region NeckfillSeed
            //if (context.Neckfills.Count() == 0)
            //{
            //    context.Neckfills.AddRange(
            //        new List<Neckfill>()
            //        {
            //            new Neckfill(){Name = "Patlıcan Boğaz Doldurma", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Neckfill(){Name = "Patates Boğaz Doldurma", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Neckfill(){Name = "Domates Boğaz Doldurma", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Neckfill(){Name = "Mısır Boğaz Doldurma", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Neckfill(){Name = "Biber Boğaz Doldurma", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now}

            //        }
            //        );
            //    context.SaveChanges();
            //}
            #endregion


            //#region FertilizerSeed GÜNCELLENDİ
            //if (context.Fertilizers.Count() == 0)
            //{
            //    context.Fertilizers.AddRange(
            //        new List<Fertilizer>()
            //        {
            //            new Fertilizer(){Name = "Dap", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Fertilizer(){Name = "Üre", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Fertilizer(){Name = "Amonyum Sülfat", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Fertilizer(){Name = "Map", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Fertilizer(){Name = "Magnezyum Sülfat", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Fertilizer(){Name = "Potasyum Sülfat", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Fertilizer(){Name = "Potasyum Nitrat", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},

            //        }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region RoleSeed
            //var role1 = new AppRole()
            //{ Name = "Yönetici", AddedBy = "DataSeeding", NormalizedName = "YÖNETICI" };
            ////var role2 = new AppRole()
            ////{ Name = "Grup Müdürü", AddedBy = "Admin", NormalizedName = "GRUP MUDURU" };
            ////var role3 = new AppRole()
            ////{ Name = "Tarla Takip Sorumlusu", AddedBy = "Admin", NormalizedName = "TARLA TAKIP SORUMLUSU" };

            //if (context.Roles.Count() == 0)
            //{
            //    context.Roles.AddRange(
            //        new List<AppRole>() { role1,/* role2, role3*/ }
            //        );
            //    context.SaveChanges();
            //}
            //#endregion


            //#region UserSeed
            //var user1 = new AppUser() { UserName = "Peyman", NormalizedUserName = "PEYMAN", FirstName = "Peyman", LastName = "Peyman", Email = "peyman@gmail.com", NormalizedEmail = "PEYMAN@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEGzAgfWC/LwdeH7i15Ps8Eq7U6EFSo1Zl/ZHWQ6xUGzwEJQxlsKiD07Ob8hX2PLyWQ==", PhoneNumber = "123456", AddedBy = "DataSeeding", IsActive = true, AddedDate = DateTime.Now };
            ////var user2 = new AppUser() { UserName = "AhmetYılmaz", NormalizedUserName = "AHMETYıLMAZ", FirstName = "Ahmet", LastName = "Yılmaz", Email = "ahmetyilmaz@gmail.com", NormalizedEmail = "AHMETYILMAZ@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEGzAgfWC/LwdeH7i15Ps8Eq7U6EFSo1Zl/ZHWQ6xUGzwEJQxlsKiD07Ob8hX2PLyWQ==", PhoneNumber = "123457", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now };
            ////var user3 = new AppUser() { UserName = "MehmetAkarsu", NormalizedUserName = "MEHMETAKARSU", FirstName = "Mehmet", LastName = "Akarsu", Email = "mehmetakarsu@gmail.com", NormalizedEmail = "MEHMETAKARSU@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEGzAgfWC/LwdeH7i15Ps8Eq7U6EFSo1Zl/ZHWQ6xUGzwEJQxlsKiD07Ob8hX2PLyWQ==", PhoneNumber = "123458", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now };
            ////var user4 = new AppUser() { UserName = "AliDurmaz", NormalizedUserName = "ALIDURMAZ", FirstName = "Ali", LastName = "Durmaz", Email = "alidurmaz@gmail.com", NormalizedEmail = "ALIDURMAZ@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEGzAgfWC/LwdeH7i15Ps8Eq7U6EFSo1Zl/ZHWQ6xUGzwEJQxlsKiD07Ob8hX2PLyWQ==", PhoneNumber = "123459", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now };


            //if (context.Users.Count() == 0)
            //{
            //    context.Users.AddRange(
            //        new List<AppUser> { user1/*, user2, user3, user4*/ }
            //        );
            //    context.SaveChanges();
            //}

            //if (context.UserRoles.Count() == 0)
            //{
            //    context.UserRoles.Add(new IdentityUserRole<string>() { UserId = user1.Id, RoleId = role1.Id });
            //    //context.UserRoles.Add(new IdentityUserRole<string>() { UserId = user2.Id, RoleId = role2.Id });
            //    //context.UserRoles.Add(new IdentityUserRole<string>() { UserId = user3.Id, RoleId = role3.Id });
            //    //context.UserRoles.Add(new IdentityUserRole<string>() { UserId = user4.Id, RoleId = role3.Id });
            //    context.SaveChanges();

            //}
            //#endregion


            //#region FarmerSeed
            //var farmer1 = new Farmer() { FirstName = "Mehmet", PhoneNumber = "12345", AddedBy = "admin", LastName = "ciftci", SupplierId = 1 };
            //var farmer2 = new Farmer() { FirstName = "Ahmet", PhoneNumber = "12346", AddedBy = "admin", LastName = "ciftci", SupplierId = 2 };
            //var farmer3 = new Farmer() { FirstName = "huseyin", PhoneNumber = "12347", AddedBy = "admin", LastName = "ciftci", SupplierId = 3 };
            //if (context.Farmers.Count() == 0)
            //{
            //    context.Farmers.AddRange(
            //        new List<Farmer> { farmer1, farmer2, farmer3 }
            //        );
            //}
            //#endregion


            #region TohumSeed
            //if (context.Seeds.Count() == 0)
            //{
            //    context.Seeds.AddRange(
            //        new List<Seed>()
            //        {
            //            new Seed(){Name = "Brooke", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Seed(){Name = "Opal", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Seed(){Name = "Hermes", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Seed(){Name = "Layd Rosetta", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},
            //            new Seed(){Name = "Orwell", AddedBy = "Admin", IsActive = true, AddedDate = DateTime.Now},

            //        }
            //        );
            //}
            #endregion


            //#region ConfirmationFormSeed

            //InfieldConfirmationForm cform1 = new InfieldConfirmationForm()
            //        {
            //              Area = 25,
            //                CheckDate = DateTime.Now,
            //                CKSNo = 15,
            //                CKSNoEvaluation = true,
            //                InfieldCode = "field1",
            //                ProductPermissionNo = "A12C",
            //                Revise = "revise",

            //                SupplierEmployeeId = 1,
            //                PeymanInspectorId = user4.Id,
            //                //PeymanInspectorSignId = 2,
            //                RegionId = 2,
            //                SupplierFarmerId = 1,
            //                //SupplierEmployeeSignId = 2,
            //                SupplierId = 1,

            //                SoilPreparationAutmnEvaluation = true,
            //                SoilPreparationSpringEvaluation = true,
            //                SheetNoEvaluation = true,
            //                SoilTypeEvaluation = true,
            //                ProductionAreaSuitabilityEvaluation = true,
            //                InfieldConfirmationReportEvaluation = true,
            //                InfieldConfirmationResult = true,
            //                LandNoEvaluation = true,
            //                ParcelNoEvaluation = true,

            //                ProductionAreaSuitabilityEvaluationDescription = null,
            //                SoilPreparationAutmnEvaluationDescription = null,
            //                SoilPreparationSpringEvaluationDescription = null,
            //                SoilTypeEvaluationDescription = null,
            //                InfieldConfirmationReportEvaluationDescription = null,
            //                PeymanInspectorSignFileName = "test1.png",
            //                SupplierEmployeeSignFileName = "test2.png",

            //                AddedBy = "Admin"
            //            };
            //InfieldConfirmationForm cform2 = new InfieldConfirmationForm()
            //{
            //    Area = 21,
            //    CheckDate = DateTime.Now,
            //    CKSNo = 15,
            //    CKSNoEvaluation = true,
            //    InfieldCode = "field2",
            //    ProductPermissionNo = "A12CDQW",
            //    Revise = "revised",

            //    SupplierEmployeeId = 2,
            //    PeymanInspectorId = user3.Id,
            //    //PeymanInspectorSignId = 2,
            //    RegionId = 4,
            //    SupplierFarmerId = 2,
            //    //SupplierEmployeeSignId = 1,
            //    SupplierId = 2,

            //    SoilPreparationAutmnEvaluation = true,
            //    SoilPreparationSpringEvaluation = true,
            //    SheetNoEvaluation = true,
            //    SoilTypeEvaluation = true,
            //    ProductionAreaSuitabilityEvaluation = true,
            //    InfieldConfirmationReportEvaluation = true,
            //    InfieldConfirmationResult = true,
            //    LandNoEvaluation = true,
            //    ParcelNoEvaluation = true,

            //    ProductionAreaSuitabilityEvaluationDescription = null,
            //    SoilPreparationAutmnEvaluationDescription = null,
            //    SoilPreparationSpringEvaluationDescription = null,
            //    SoilTypeEvaluationDescription = null,
            //    InfieldConfirmationReportEvaluationDescription = null,
            //    PeymanInspectorSignFileName = "test1.png",
            //    SupplierEmployeeSignFileName = "test2.png",

            //    AddedBy = "Admin"
            //};
            //InfieldConfirmationForm cform3 = new InfieldConfirmationForm() {
            //    Area = 41,
            //    CheckDate = DateTime.Now,
            //    CKSNo = 11,
            //    CKSNoEvaluation = true,
            //    InfieldCode = "field3",
            //    ProductPermissionNo = "ADGSG2123",
            //    Revise = "revised",

            //    SupplierEmployeeId = 2,
            //    PeymanInspectorId = user3.Id,
            //    //PeymanInspectorSignId = 1,
            //    RegionId = 1,
            //    SupplierFarmerId = 2,
            //    //SupplierEmployeeSignId = 2,
            //    SupplierId = 2,

            //    SoilPreparationAutmnEvaluation = true,
            //    SoilPreparationSpringEvaluation = true,
            //    SheetNoEvaluation = true,
            //    SoilTypeEvaluation = true,
            //    ProductionAreaSuitabilityEvaluation = true,
            //    InfieldConfirmationReportEvaluation = true,
            //    InfieldConfirmationResult = true,
            //    LandNoEvaluation = true,
            //    ParcelNoEvaluation = true,

            //    ProductionAreaSuitabilityEvaluationDescription = null,
            //    SoilPreparationAutmnEvaluationDescription = null,
            //    SoilPreparationSpringEvaluationDescription = null,
            //    SoilTypeEvaluationDescription = null,
            //    InfieldConfirmationReportEvaluationDescription = null,
            //    PeymanInspectorSignFileName = "test1.png",
            //    SupplierEmployeeSignFileName = "test2.png",

            //    AddedBy = "Admin"
            //};
            //InfieldConfirmationForm cform4 = new InfieldConfirmationForm()
            //{
            //    Area = 21,
            //    CheckDate = DateTime.Now,
            //    CKSNo = 15,
            //    CKSNoEvaluation = true,
            //    InfieldCode = "field4",
            //    ProductPermissionNo = "A12CFFHDQW",
            //    Revise = "revised",

            //    SupplierEmployeeId = 3,
            //    PeymanInspectorId = user4.Id,
            //    //PeymanInspectorSignId = 1,
            //    RegionId = 3,
            //    SupplierFarmerId = 3,
            //    //SupplierEmployeeSignId = 1,
            //    SupplierId = 3,

            //    SoilPreparationAutmnEvaluation = true,
            //    SoilPreparationSpringEvaluation = true,
            //    SheetNoEvaluation = true,
            //    SoilTypeEvaluation = true,
            //    ProductionAreaSuitabilityEvaluation = true,
            //    InfieldConfirmationReportEvaluation = true,
            //    InfieldConfirmationResult = true,
            //    LandNoEvaluation = true,
            //    ParcelNoEvaluation = true,

            //    ProductionAreaSuitabilityEvaluationDescription = null,
            //    SoilPreparationAutmnEvaluationDescription = null,
            //    SoilPreparationSpringEvaluationDescription = null,
            //    SoilTypeEvaluationDescription = null,
            //    InfieldConfirmationReportEvaluationDescription = null,
            //    PeymanInspectorSignFileName = "test1.png",
            //    SupplierEmployeeSignFileName = "test2.png",

            //    AddedBy = "Admin"
            //};

            //if (context.InfieldConfirmationForms.Count() == 0)
            //{
            //    context.InfieldConfirmationForms.AddRange(
            //        cform1, cform2,cform3,cform4
            //        );
            //    context.SaveChanges();
            //}
            //#endregion





            //#region ProductGrowthFormSeed

            //InfieldProductGrowthForm pgform1 = new InfieldProductGrowthForm() {
            //    AddedBy = "Admin",
            //    Area = cform1.Area,
            //    BloomingDate = DateTime.Now,
            //    InfieldCode = cform1.InfieldCode,
            //    InfieldConfirmationFormId = cform1.ID,
            //    PlantEmergenceFrequency = 2,
            //    PlantEndDate = DateTime.Now,
            //    PlantGrowthFrequency = 2,
            //    ProductionYear = 2021,
            //    RegionId = cform1.RegionId,
            //    SupplierId = cform1.SupplierId,
            //    Type = "type1"
            //};

            //InfieldProductGrowthForm pgform2 = new InfieldProductGrowthForm()
            //{
            //    AddedBy = "Admin",
            //    Area = cform2.Area,
            //    BloomingDate = DateTime.Now,
            //    InfieldCode = cform2.InfieldCode,
            //    InfieldConfirmationFormId = cform2.ID,
            //    PlantEmergenceFrequency = 2,
            //    PlantEndDate = DateTime.Now,
            //    PlantGrowthFrequency = 2,
            //    ProductionYear = 2021,
            //    RegionId = cform2.RegionId,
            //    SupplierId = cform2.SupplierId,
            //    Type = "type2"
            //};           
            //InfieldProductGrowthForm pgform3 = new InfieldProductGrowthForm()
            //{
            //    AddedBy = "Admin",
            //    Area = cform3.Area,
            //    BloomingDate = DateTime.Now,
            //    InfieldCode = cform3.InfieldCode,
            //    InfieldConfirmationFormId = cform3.ID,
            //    PlantEmergenceFrequency = 2,
            //    PlantEndDate = DateTime.Now,
            //    PlantGrowthFrequency = 2,
            //    ProductionYear = 2021,
            //    RegionId = cform3.RegionId,
            //    SupplierId = cform3.SupplierId,
            //    Type = "type2"
            //};           
            //InfieldProductGrowthForm pgform4 = new InfieldProductGrowthForm()
            //{
            //    AddedBy = "Admin",
            //    Area = cform4.Area,
            //    BloomingDate = DateTime.Now,
            //    InfieldCode = cform4.InfieldCode,
            //    InfieldConfirmationFormId = cform4.ID,
            //    PlantEmergenceFrequency = 1,
            //    PlantEndDate = DateTime.Now,
            //    PlantGrowthFrequency = 2,
            //    ProductionYear = 2021,
            //    RegionId = cform4.RegionId,
            //    SupplierId = cform4.SupplierId,
            //    Type = "type4"
            //};

            //if (context.InfieldProductGrowthForms.Count() == 0 && context.InfieldConfirmationForms.Count() > 1)
            //{
            //    context.InfieldProductGrowthForms.AddRange(new List<InfieldProductGrowthForm>() {
            //        pgform1, pgform2, pgform3, pgform4
            //    });
            //    context.SaveChanges();
            //}

            //#endregion

            //#region HarvestFormSeed

            //if (context.InfieldHarvestForms.Count() == 0)
            //{
            //    context.InfieldHarvestForms.AddRange(
            //        new List<InfieldHarvestForm>()
            //        {
            //            new InfieldHarvestForm(){
            //               Area = pgform1.Area,
            //               AddedBy = "Admin",
            //               AverageDefectSum = 15,
            //               InfieldCode = pgform1.InfieldCode,
            //               IsDrugHarvestIntervalAppropriate = true,
            //               MaturitySuitability = true,
            //               CheckDate = DateTime.Now,
            //               RegionId = pgform1.RegionId,
            //               SupplierId = pgform1.SupplierId,
            //               TargetHarvestTime = DateTime.Now,
            //               Type = "tip1",
            //               InfieldProductGrowthFormId = pgform1.ID
            //            },
            //            new InfieldHarvestForm(){
            //               Area = pgform1.Area,
            //               AddedBy = "Admin",
            //               AverageDefectSum = 55,
            //               InfieldCode = pgform1.InfieldCode,
            //               IsDrugHarvestIntervalAppropriate = true,
            //               MaturitySuitability = true,
            //               CheckDate = DateTime.Now,
            //               RegionId = pgform1.RegionId,
            //               SupplierId = pgform1.SupplierId,
            //               TargetHarvestTime = DateTime.Now,
            //               Type = "tip4",
            //               InfieldProductGrowthFormId = pgform1.ID
            //            },
            //            new InfieldHarvestForm(){
            //               Area = pgform2.Area,
            //               AddedBy = "Admin",
            //               AverageDefectSum = 25,
            //               InfieldCode = pgform2.InfieldCode,
            //               IsDrugHarvestIntervalAppropriate = true,
            //               MaturitySuitability = true,
            //               CheckDate = DateTime.Now,
            //               RegionId = pgform2.RegionId,
            //               SupplierId = pgform2.SupplierId,
            //               TargetHarvestTime = DateTime.Now,
            //               InfieldProductGrowthFormId = pgform2.ID,
            //               Type = "tip2"
            //            },
            //            new InfieldHarvestForm(){
            //               Area = pgform2.Area,
            //               AddedBy = "Admin",
            //               AverageDefectSum = 15,
            //               InfieldCode = pgform2.InfieldCode,
            //               IsDrugHarvestIntervalAppropriate = true,
            //               MaturitySuitability = true,
            //               CheckDate = DateTime.Now,
            //               RegionId = pgform2.RegionId,
            //               SupplierId = pgform2.SupplierId,
            //               TargetHarvestTime = DateTime.Now,
            //               Type = "tip3",
            //               InfieldProductGrowthFormId = pgform2.ID

            //            },
            //        });
            //    context.SaveChanges();

            //}


            //#endregion

            //#region HoeingFormSeed

            //if (context.InfieldGrowthHoeingForms.Count() == 0 && context.InfieldProductGrowthForms.Count() > 3)
            //{
            //    context.InfieldGrowthHoeingForms.AddRange(new List<InfieldGrowthHoeingForm>(){
            //        new InfieldGrowthHoeingForm(){
            //            AddedBy = "Yönetici",
            //            HoeingDate = DateTime.Now,
            //            HoeingId = 2,
            //            InfieldProductGrowthFormId = pgform1.ID,
            //        },
            //         new InfieldGrowthHoeingForm(){
            //            AddedBy = "Yönetici",
            //            HoeingDate = DateTime.Now,
            //            HoeingId = 2,
            //            InfieldProductGrowthFormId = pgform1.ID,

            //        },
            //          new InfieldGrowthHoeingForm(){
            //            AddedBy = "Yönetici",
            //            HoeingDate = DateTime.Now,
            //            HoeingId = 1,
            //            InfieldProductGrowthFormId = pgform2.ID,

            //        },
            //           new InfieldGrowthHoeingForm(){
            //            AddedBy = "Yönetici",
            //            HoeingDate = DateTime.Now,
            //            HoeingId = 4,
            //            InfieldProductGrowthFormId = pgform2.ID,

            //        }
            //    });
            //    context.SaveChanges();
            //}
            //#endregion


            //#region DofFormSeed

            //if (context.InfieldDofForms.Count() == 0)
            //{
            //    context.InfieldDofForms.AddRange(new List<InfieldDofForm>(){
            //        new InfieldDofForm(){
            //            AddedBy = "Yönetici",
            //            AuditNo = "12",
            //            CheckDate = DateTime.Now,
            //            CompletedDate = DateTime.Now,
            //            DOFCheckProblemId = 2,
            //            DOFPreventiveActionId = 3,
            //            InfieldCode = "field1",
            //            RegionId = pgform1.RegionId,
            //            SupplierEmployeeId = 1,
            //            SupplierId = pgform1.SupplierId,
            //            Result = true,
            //            InfieldProductGrowthFormId = pgform1.ID
            //        },

            //          new InfieldDofForm(){
            //            AddedBy = "Yönetici",
            //            AuditNo = "7",
            //            CheckDate = DateTime.Now,
            //            CompletedDate = DateTime.Now,
            //            DOFCheckProblemId = 3,
            //            DOFPreventiveActionId = 2,
            //            InfieldCode = "field1",
            //            RegionId = pgform1.RegionId,
            //            SupplierEmployeeId = 1,
            //            SupplierId = pgform1.SupplierId,
            //            Result = true,
            //            InfieldProductGrowthFormId = pgform1.ID

            //        },

            //          new InfieldDofForm(){
            //            AddedBy = "Yönetici",
            //            AuditNo = "123asfsgd",
            //            CheckDate = DateTime.Now,
            //            CompletedDate = DateTime.Now,
            //            DOFCheckProblemId = 3,
            //            DOFPreventiveActionId = 1,
            //            InfieldCode = "field2",
            //            RegionId = pgform2.RegionId,
            //            SupplierEmployeeId = 2,
            //            SupplierId = pgform2.SupplierId,
            //            Result = true,
            //            InfieldProductGrowthFormId = pgform2.ID

            //        },

            //          new InfieldDofForm(){
            //            AddedBy = "Yönetici",
            //            AuditNo = "152AB",
            //            CheckDate = DateTime.Now,
            //            CompletedDate = DateTime.Now,
            //            DOFCheckProblemId = 3,
            //            DOFPreventiveActionId = 1,
            //            InfieldCode = "field2",
            //            RegionId = pgform2.SupplierId,
            //            SupplierEmployeeId = 3,
            //            SupplierId = pgform2.SupplierId,
            //            Result = true,
            //            InfieldProductGrowthFormId = pgform2.ID

            //        },

            //    });
            //    context.SaveChanges();
            //}
            //#endregion


            //#region IrrigationFormSeed
            //if (context.InfieldGrowthIrrigationForms.Count() == 0 && context.InfieldProductGrowthForms.Count() > 3)
            //{
            //    context.InfieldGrowthIrrigationForms.AddRange(new List<InfieldGrowthIrrigationForm>() {
            //        new InfieldGrowthIrrigationForm()
            //            {
            //                InfieldProductGrowthFormId = pgform1.ID,
            //                IrrigationDate = DateTime.Now,
            //                IrrigationId = 2,
            //                AddedBy = "Yönetici"
            //            },
            //         new InfieldGrowthIrrigationForm()
            //            {
            //                InfieldProductGrowthFormId = pgform1.ID,
            //                IrrigationDate = DateTime.Now,
            //                IrrigationId = 3,
            //                AddedBy = "Saha Mühendisi"
            //            },
            //          new InfieldGrowthIrrigationForm()
            //            {
            //                InfieldProductGrowthFormId = pgform2.ID,
            //                IrrigationDate = DateTime.Now,
            //                IrrigationId = 2,
            //                AddedBy = "Veri Girişi"
            //            },
            //           new InfieldGrowthIrrigationForm()
            //            {
            //                InfieldProductGrowthFormId = pgform2.ID,
            //                IrrigationDate = DateTime.Now,
            //                IrrigationId = 3,
            //                AddedBy = "Veri Girişi"
            //            }

            //    });
            //    context.SaveChanges();
            //}

            //#endregion


            //#region NeckfillFormSeed
            ////if (context.InfieldGrowthNeckfillForms.Count() == 0 && context.InfieldProductGrowthForms.Count() >= 3)
            ////{
            ////    context.InfieldGrowthNeckfillForms.AddRange(new List<InfieldGrowthNeckfillForm>() {
            ////        new InfieldGrowthNeckfillForm()
            ////            {
            ////                InfieldProductGrowthFormId = 2,
            ////                NeckfillDate = DateTime.Now,
            ////                NeckfillId = 1,
            ////                AddedBy = "Yönetici"
            ////            },
            ////         new InfieldGrowthNeckfillForm()
            ////            {
            ////                InfieldProductGrowthFormId = 1,
            ////                NeckfillDate = DateTime.Now,
            ////                NeckfillId = 3,
            ////                AddedBy = "Saha Mühendisi"
            ////            },
            ////          new InfieldGrowthNeckfillForm()
            ////            {
            ////                InfieldProductGrowthFormId = 2,
            ////                NeckfillDate = DateTime.Now,
            ////                NeckfillId = 2,
            ////                AddedBy = "Veri Girişi"
            ////            },
            ////          new InfieldGrowthNeckfillForm()
            ////            {
            ////                InfieldProductGrowthFormId = 3,
            ////                NeckfillDate = DateTime.Now,
            ////                NeckfillId = 2,
            ////                AddedBy = "Veri Girişi"
            ////            },
            ////          new InfieldGrowthNeckfillForm()
            ////            {
            ////                InfieldProductGrowthFormId = 2,
            ////                NeckfillDate = DateTime.Now,
            ////                NeckfillId = 4,
            ////                AddedBy = "Veri Girişi"
            ////            },
            ////    });
            ////    context.SaveChanges();
            ////}

            //#endregion


            //#region PlantingFormSeed
            //if (context.InfieldGrowthPlantingForms.Count() == 0 && context.InfieldProductGrowthForms.Count() > 3)
            //{
            //    context.InfieldGrowthPlantingForms.AddRange(new List<InfieldGrowthPlantingForm>() {
            //        new InfieldGrowthPlantingForm()
            //            {
            //                InfieldProductGrowthFormId = pgform1.ID,
            //                PlantingDate = DateTime.Now,
            //                SeedLotNo = "a1",
            //                PlantingDept = 13,
            //                SeedAmount = 25,
            //                Sprouting = true,
            //                AddedBy = "Yönetici"
            //            },
            //         new InfieldGrowthPlantingForm()
            //            {
            //                InfieldProductGrowthFormId = pgform1.ID,
            //                PlantingDate = DateTime.Now,
            //                SeedLotNo = "a2",
            //                PlantingDept = 18,
            //                SeedAmount = 15,
            //                Sprouting = true,
            //                AddedBy = "Yönetici"
            //            },
            //          new InfieldGrowthPlantingForm()
            //            {
            //                InfieldProductGrowthFormId = pgform2.ID,
            //                PlantingDate = DateTime.Now,
            //                SeedLotNo = "a3",
            //                PlantingDept = 15,
            //                SeedAmount = 50,
            //                Sprouting = true,
            //                AddedBy = "Veri Girişi"
            //            },
            //          new InfieldGrowthPlantingForm()
            //            {
            //                InfieldProductGrowthFormId = pgform2.ID,
            //                PlantingDate = DateTime.Now,
            //                SeedLotNo = "a4",
            //                PlantingDept = 15,
            //                SeedAmount = 50,
            //                Sprouting = true,
            //                AddedBy = "Veri Girişi"
            //            }
            //    });
            //    context.SaveChanges();
            //}
            //#endregion


            //#region ProductTrackingSeed
            //if (context.InfieldGrowthProductTrackingForms.Count() == 0 && context.InfieldProductGrowthForms.Count() > 0 && context.InfieldDofForms.Count() > 1)
            //{
            //    context.InfieldGrowthProductTrackingForms.AddRange(new List<InfieldGrowthProductTrackingForm>() {
            //        new InfieldGrowthProductTrackingForm()
            //        {
            //            AddedBy = "Admin",
            //            CheckDate = DateTime.Now,
            //            InfieldDofFormId = 1,
            //            InfieldProductGrowthFormId = pgform1.ID,
            //            Investigation = true,
            //            ProblemReason = "Tohum bilgisi yok",

            //        },
            //         new InfieldGrowthProductTrackingForm()
            //        {
            //            AddedBy = "Admin",
            //            CheckDate = DateTime.Now,
            //            InfieldDofFormId = 2,
            //            InfieldProductGrowthFormId = pgform1.ID,
            //            Investigation = true,
            //            ProblemReason = "Gübrede sıkıntı var",

            //        },
            //          new InfieldGrowthProductTrackingForm()
            //        {
            //            AddedBy = "Admin",
            //            CheckDate = DateTime.Now,
            //            InfieldDofFormId = 3,
            //            InfieldProductGrowthFormId = pgform2.ID,
            //            Investigation = true,
            //            ProblemReason = "Çapalamada sıkıntı var",

            //        },
            //           new InfieldGrowthProductTrackingForm()
            //        {
            //            AddedBy = "Admin",
            //            CheckDate = DateTime.Now,
            //            InfieldDofFormId = 4,
            //            InfieldProductGrowthFormId = pgform2.ID,
            //            Investigation = true,
            //            ProblemReason = "Kazıma işlemi başarısız",

            //        }

            //    });
            //    context.SaveChanges();
            //}

            //#endregion


            //#region SoilPreparationFormSeed
            //if (context.InfieldGrowthSoilPreparationForms.Count() == 0)
            //{
            //    context.InfieldGrowthSoilPreparationForms.AddRange(new List<InfieldGrowthSoilPreparationForm>() { 
            //        new InfieldGrowthSoilPreparationForm(){
            //        EquipmentId = 1,
            //        InfieldProductGrowthFormId = 1,
            //        AddedBy = "Admin",
            //        PreparationDate = DateTime.Now,
            //        Purpose = "Yeni toprak hazılrığı"
            //        },
            //         new InfieldGrowthSoilPreparationForm(){
            //        EquipmentId = 2,
            //        InfieldProductGrowthFormId = 1,
            //        AddedBy = "Admin",
            //        PreparationDate = DateTime.Now,
            //        Purpose = "Yeni toprak hazılrığı"
            //        },
            //          new InfieldGrowthSoilPreparationForm(){
            //        EquipmentId = 3,
            //        InfieldProductGrowthFormId = 2,
            //        AddedBy = "Admin",
            //        PreparationDate = DateTime.Now,
            //        Purpose = "Yeni toprak hazılrığı"
            //        },
            //           new InfieldGrowthSoilPreparationForm(){
            //        EquipmentId = 4,
            //        InfieldProductGrowthFormId = 2,
            //        AddedBy = "Admin",
            //        PreparationDate = DateTime.Now,
            //        Purpose = "Yeni toprak hazılrığı"
            //        }
            //    });
            //    context.SaveChanges();
            //}


            //#endregion


            //#region UsedChemicalsFormSeed
            //if (context.InfieldGrowthUsedChemicalsForms.Count() == 0)
            //{
            //    context.InfieldGrowthUsedChemicalsForms.AddRange(new List<InfieldGrowthUsedChemicalsForm>() {
            //    new InfieldGrowthUsedChemicalsForm()
            //    {
            //        ChemicalDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        ChemicalId = 1,
            //        InfieldProductGrowthFormId = 1,
            //        Purpose = "Böcek yok etme"
            //    },
            //     new InfieldGrowthUsedChemicalsForm()
            //    {
            //        ChemicalDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        ChemicalId = 2,
            //        InfieldProductGrowthFormId = 1,
            //        Purpose = "Yılan yok etme"
            //    },
            //      new InfieldGrowthUsedChemicalsForm()
            //    {
            //        ChemicalDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        ChemicalId = 3,
            //        InfieldProductGrowthFormId = 2,
            //        Purpose = "Sinek yok etme"
            //    },
            //      new InfieldGrowthUsedChemicalsForm()
            //    {
            //        ChemicalDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        ChemicalId = 3,
            //        InfieldProductGrowthFormId = 2,
            //        Purpose = "Sürüngen yok etme"
            //    }

            //    });
            //}
            //#endregion


            //#region UsedFertilizersFormSeed
            //if (context.InfieldGrowthUsedFertilizersForms.Count() == 0)
            //{
            //    context.InfieldGrowthUsedFertilizersForms.AddRange(new List<InfieldGrowthUsedFertilizersForm>() {
            //    new InfieldGrowthUsedFertilizersForm()
            //    {
            //        FertilizerDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        FertilizerId = 1,
            //        InfieldProductGrowthFormId = 1,
            //        Purpose = "Böcek yok etme"
            //    },
            //     new InfieldGrowthUsedFertilizersForm()
            //    {
            //        FertilizerDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        FertilizerId = 2,
            //        InfieldProductGrowthFormId = 1,
            //        Purpose = "Yılan yok etme"
            //    },
            //      new InfieldGrowthUsedFertilizersForm()
            //    {
            //        FertilizerDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        FertilizerId = 3,
            //        InfieldProductGrowthFormId = 2,
            //        Purpose = "Sinek yok etme"
            //    },
            //      new InfieldGrowthUsedFertilizersForm()
            //    {
            //        FertilizerDate = DateTime.Now,
            //        AddedBy = "Admin",
            //        FertilizerId = 3,
            //        InfieldProductGrowthFormId = 2,
            //        Purpose = "Sürüngen yok etme"
            //    }

            //    });
            //}
            //#endregion


            #region MenuSeed
            //if (context.Menus.Count() == 0)
            //{
            //    context.Menus.AddRange(new List<Menu>() {
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Ana Sayfa",
                    
            //    },
            //     new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Onay Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Toprak Hazırlık Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Ekim Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Kullanılan Zirai İlaç Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Kullanılan Gübre Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Çapalama Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Boğaz Doldurma Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Sulama Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Ürün İzleme Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Denetleme/Önleme Faaliyetleri Formu",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Hasat Formu",

            //    },



            //     new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Ayarlar",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Zira İlaç",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Ekipman",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Gübre",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Çapalama",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Sulama",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Boğaz Doldurma",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Bölge",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Tespit Edilen Problem",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Alınacak Düzenleyici ve Önleyici Faaliyetler",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Tedarikçi",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Tedarikçi Personeli",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Çiftçi",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Kullanıcılar",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Roller",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Detaylar",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Şifre Değiştirme",

            //    },

            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Profil",

            //    },
            //    new Menu()
            //    {
            //        AddedBy = "DataSeeding",
            //        Name = "Çıkış",

            //    },

            //    });
            //}
            //context.SaveChanges();
            #endregion

           
            //var roleId1 = context.Roles.FirstOrDefault(a => a.Name == role1.Name).Id;
            //var roleId2 = context.Roles.FirstOrDefault(a => a.Name == role2.Name).Id;
            //var roleId3 = context.Roles.FirstOrDefault(a => a.Name == role3.Name).Id;
            #region MenuAuthSeed
            //if (context.MenuAuthorizations.Count() == 0)
            //{
            //    foreach (Menu menu in context.Menus.Where(a => a.IsActive).ToList())
            //    {
            //        context.MenuAuthorizations.Add(new MenuAuthorization() { AddedBy = "DataSeeding", IsAuthorise = true, RoleID = roleId1, MenuId = menu.ID });
            //    }

            //    //foreach (Menu menu in context.Menus.Where(a => a.IsActive).ToList())
            //    //{
            //    //    context.MenuAuthorizations.Add(new MenuAuthorization() { AddedBy = "Admin", IsAuthorise = true, RoleID = roleId2, MenuId = menu.ID });
            //    //}

            //    //foreach (Menu menu in context.Menus.Where(a => a.IsActive).ToList())
            //    //{
            //    //    context.MenuAuthorizations.Add(new MenuAuthorization() { AddedBy = "Admin", IsAuthorise = true, RoleID = roleId3, MenuId = menu.ID });
            //    //}
            //}
            //context.SaveChanges();
            #endregion

        }
    }
}
