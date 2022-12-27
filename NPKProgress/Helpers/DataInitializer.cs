using Microsoft.AspNetCore.Identity;
using NPKProgress.Data;
using NPKProgress.Models;

namespace NPKProgress.Helpers
{
    public static class DataInitializer
    {
        public static async Task SeedData(AppDbContext db)
        {
            await SeedDiseases(db);
            await db.SaveChangesAsync();
        }

        private static async Task SeedDiseases(AppDbContext db)
        {
            if (db.Diseases.Any())
                return;

            // Справочник МКБ содержит код (состоящий из 3 символов) и название болезни
            // При желании можно заполнить все данные из https://mkb-10.com/
            // Пока добавим только тестовые данные
            await db.Diseases.AddAsync(new Disease()
            {
                Id = "A00",
                Description = "Холера"
            });
            await db.Diseases.AddAsync(new Disease()
            {
                Id = "I00",
                Description = "Ревматическая лихорадка без упоминания о вовлечении сердца"
            });
            await db.Diseases.AddAsync(new Disease()
            {
                Id = "I01",
                Description = "Ревматическая лихорадка с вовлечением сердца"
            });
            await db.Diseases.AddAsync(new Disease()
            {
                Id = "I30",
                Description = "Острый перикардит"
            });
        }
    }
}
