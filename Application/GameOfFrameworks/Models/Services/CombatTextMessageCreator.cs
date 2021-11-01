using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.UniversalSkills;
using GameOfFrameworks.Models.BattleScene;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using System;

namespace GameOfFrameworks.Models.Services
{
    public class CombatTextMessageCreator
    {
        private static BattleSkillUseViewImageHandler SkillImageHandler;
        public CombatTextMessageCreator()
        {
            var skillToSkillViewConverter = new SkillToSkillViewConverter(ArmoryTemporaryData.PlayerModel.Specialization);

            SkillImageHandler = new();
            SkillImageHandler.BattleSceneSkills = skillToSkillViewConverter.ConvertRangeToList(ArmoryTemporaryData.PlayerSkills.Skills);
            SkillImageHandler.BattleSceneSkills.Add(skillToSkillViewConverter.Convert(new RegularAttack()));
        }
        public CombatTextMessageView Create(ACTION_TYPE actionType, string message, SERVICE_OWNER owner, ISkill skill)
        {
            var combatTextMessage = new CombatTextMessageView();
            combatTextMessage.ActionImageView = BattleActionTypeViewImageHandler.Handle(actionType);
            combatTextMessage.SkillUseImageView = SkillImageHandler.GetImagePath(skill);
            combatTextMessage.Message = message;
            combatTextMessage.Time = DateTime.Now.ToString("H:mm:ss");

            if (owner == SERVICE_OWNER.Player)
            {
                combatTextMessage.DealerImageMiniature = ArmoryTemporaryData.PlayerModel.AvatarPath.MiniaturePath;
            }
            else
            {
                combatTextMessage.DealerImageMiniature = null;
            }
            return combatTextMessage;
        }
    }
}
