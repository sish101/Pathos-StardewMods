using Pathoschild.Stardew.FastAnimations.Framework;
using StardewModdingAPI;
using StardewValley;

namespace Pathoschild.Stardew.FastAnimations.Handlers
{
    /// <summary>Handles the harvesting animation.</summary>
    internal class HarvestHandler : BaseAnimationHandler
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="multiplier">The animation speed multiplier to apply.</param>
        public HarvestHandler(int multiplier)
            : base(multiplier) { }

        /// <summary>Get whether the animation is currently active.</summary>
        /// <param name="playerAnimationID">The player's current animation ID.</param>
        public override bool IsEnabled(int playerAnimationID)
        {
            return
                Context.IsWorldReady
                && Game1.player.Sprite.CurrentAnimation != null
                && (
                    playerAnimationID == FarmerSprite.harvestItemUp
                    || playerAnimationID == FarmerSprite.harvestItemRight
                    || playerAnimationID == FarmerSprite.harvestItemDown
                    || playerAnimationID == FarmerSprite.harvestItemLeft
                );
        }

        /// <summary>Perform any logic needed on update while the animation is active.</summary>
        /// <param name="playerAnimationID">The player's current animation ID.</param>
        public override void Update(int playerAnimationID)
        {
            this.SpeedUpPlayer(this.Multiplier);
        }
    }
}
