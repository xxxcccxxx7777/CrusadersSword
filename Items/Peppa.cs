using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrusadersSword.Items
{
  public class Peppa : ModItem
  {
    public virtual void SetStaticDefaults()
    {
      this.DisplayName.SetDefault("Crusaders-sword");
      this.Tooltip.SetDefault("This is a Crusaders epic sword weilded by the God Of War himself.");
    }

    public virtual void OnHitNPC(
      Player player,
      NPC target,
      int damage,
      float knockBack,
      bool crit)
    {
      int num = damage / 180;
      player.statLife += num;
    }

    public virtual void SetDefaults()
    {
      this.Item.damage = 2500;
      this.Item.DamageType = DamageClass.Melee;
      ((Entity) this.Item).width = 120;
      ((Entity) this.Item).height = 120;
      this.Item.useTime = 40;
      this.Item.useAnimation = 40;
      this.Item.useStyle = 1;
      this.Item.knockBack = 20f;
      this.Item.useTurn = true;
      this.Item.value = 42069911;
      this.Item.rare = 11;
      this.Item.UseSound = new SoundStyle?(SoundID.Item1);
      this.Item.autoReuse = true;
      this.Item.scale = 8f;
      this.Item.crit = 95;
    }

    public virtual void AddRecipes()
    {
    }
  }
}
