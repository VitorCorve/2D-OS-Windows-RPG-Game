using GameEngine.BattleMaster;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Data.Services;
using GameEngine.LevelUpMechanics.Services;
using GameEngine.Player;
using GameEngine.SpecializationMechanics.Mage.Skills;
using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameEngine.SpecializationMechanics.Warrior.Skills;
using System;

namespace EngineTest
{
    public class TestBattleMasterMechanics
    {
        public TestBattleMasterMechanics()
        {

            var loadGameService = new LoadGameService();
            var playerData = loadGameService.Load("Wulfgar_1");

            playerData.ListOfSkills = null;
            playerData.ListOfSkills = new PlayerSkillList();

            var availableskills = new GetAvailablePlayerSkills(playerData.PlayerModel);
            var skillLevelUpService = new SkillLevelUpService(playerData.PlayerModel, playerData.ListOfSkills);

            // warrior skills W -->
/*            var powerHit = new PowerHit();
            var lastManStanding = new LastManStanding();
            var wideBlow = new WideBlow();
            var deepDefense = new DeepDefense();
            var crushLegs = new CrushLegs();

            powerHit.SkillLevel = 1;
            lastManStanding.SkillLevel = 1;
            wideBlow.SkillLevel = 1;
            deepDefense.SkillLevel = 1;
            crushLegs.SkillLevel = 1;

            skillLevelUpService.LearnDirectly(lastManStanding);
            skillLevelUpService.LearnDirectly(powerHit);
            skillLevelUpService.LearnDirectly(wideBlow);
            skillLevelUpService.LearnDirectly(deepDefense);
            skillLevelUpService.LearnDirectly(crushLegs);*/
            // <-- W/

            // rogue skills R -->
/*            var backstab = new Backstab();
            var dissapearIntoTheShadows = new DissapearIntoTheShadows();
            var findTheWeakness = new FindTheWeakness();
            var rend = new Rend();
            var stun = new Stun();

            backstab.SkillLevel = 1;
            dissapearIntoTheShadows.SkillLevel = 1;
            findTheWeakness.SkillLevel = 1;
            rend.SkillLevel = 1;
            stun.SkillLevel = 1;

            skillLevelUpService.LearnDirectly(backstab);
            skillLevelUpService.LearnDirectly(dissapearIntoTheShadows);
            skillLevelUpService.LearnDirectly(findTheWeakness);
            skillLevelUpService.LearnDirectly(rend);
            skillLevelUpService.LearnDirectly(stun);*/
            // <-- R/

            // mage skills M -->
            var fireball = new Fireball();
            var heal = new Heal();
            var magicShield = new MagicShield();
            var polymorph = new Polymorph();
            var soulburn = new Soulburn();

            fireball.SkillLevel = 1;
            heal.SkillLevel = 1;
            magicShield.SkillLevel = 1;
            polymorph.SkillLevel = 1;
            soulburn.SkillLevel = 1;

            skillLevelUpService.LearnDirectly(fireball);
            skillLevelUpService.LearnDirectly(heal);
            skillLevelUpService.LearnDirectly(magicShield);
            skillLevelUpService.LearnDirectly(polymorph);
            skillLevelUpService.LearnDirectly(soulburn);
            // <-- M/

            var skillEffectObserver = new SkillEffectObserver(playerData);

            var battleMaster = new BattleMaster(playerData);

            var specialAbilitiesObserverService = new SpecialAbilitiesObserverService(battleMaster.PlayerCombatManager.Dealer, playerData.ListOfSkills.Skills);

            battleMaster.StartFight();

            foreach (var item in battleMaster.Observers)
            {
                item.Log += Notification;
            }

            battleMaster.UseSkill(0);
            battleMaster.UseSkill(1);
            battleMaster.UseSkill(2);
            battleMaster.UseSkill(3);
            battleMaster.UseSkill(4);

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("\tPlayer cooldowns:\n");
                foreach (var item in skillEffectObserver.DealerCoolDowns)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Skill name: {item.SkillName}\t Skill ID: {item.Skill_ID}\t Skill cooldown: {item.CoolDown}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("\n\tPlayer buffs:\n");
                foreach (var item in skillEffectObserver.EffectsOnDealer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Skill name: {item.SkillName}\t Skill ID: {item.Skill_ID}\t debuff duration: {((ISkillDuration)item).ActiveDuration}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("\n\tEnemy debuffs:\n");
                foreach (var item in skillEffectObserver.EffecrsOnTarget)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Skill name: {item.SkillName}\t Skill ID: {item.Skill_ID}\t debuff duration: {((ISkillDuration)item).ActiveDuration}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("\n\tReady:\n");
                foreach (var item in battleMaster.SkillList)
                {
                        if (item.CoolDown == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Skill name: {item.SkillName}\t Skill ID: {item.Skill_ID}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    
                }

                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ReadLine();
        }
        private static void Notification(string message)
        {
/*            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;*/
        }

    }
}
