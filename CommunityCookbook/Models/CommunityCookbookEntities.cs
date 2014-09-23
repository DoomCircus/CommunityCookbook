namespace CommunityCookbook.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CommunityCookbookEntities : DbContext
    {
        public CommunityCookbookEntities()
            : base("name=CommunityCookbookEntities")
        {
        }

        public virtual DbSet<IngredientMeasurement> IngredientMeasurements { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<InstructionIngredient> InstructionIngredients { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategories { get; set; }
        public virtual DbSet<RecipeInstruction> RecipeInstructions { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
