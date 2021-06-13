using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using WinFormsApp1.EquipmentData;
using WinFormsApp1.EquipmentData.Items;

namespace WinFormsApp1
{
    public class Player : Mechanics, ISkills
    {
        public bool IsAlive = true;
        public string name;
        public int level = 1;
        public string gender;
        public int experience = 0;
        public double maxExperience = 0;
        public string Kind = "human";
        public string Bio { get; set; }
        public Image Avatar { get; set; }
        public string AvatarPath { get; set; }
        public string IconPath { get; set; }

        public string Specialization { get; set; }


        public int healthpoints = 0;
        public int maxHP = 0;
        public int healthRegen;

        public int BaseHP = 100;
        public int additionalHealthpoints = 0;
        public int additionalMaxHP = 0;
        public int additionalHealthRegen;

        public int baseHealthpoints = 0;
        public int baseMaxHP = 0;
        public int baseHealthRegen;

        public int energy = 0;
        public int maxEnergy = 0;
        public int energyRegen = 0;

        public int additionalEnergy = 0;
        public int additionalMaxEnergy = 0;
        public int additionalEnergyRegen = 0;

        public int baseEnergy = 0;
        public int baseMaxEnergy = 0;
        public int baseEnergyRegen = 0;

        public int mana = 0;
        public int maxMana = 0;
        public int manaRegen = 0;

        public int additionalMana = 0;
        public int additionalMaxMana = 0;
        public int additionalManaRegen = 0;

        public int baseMana = 0;
        public int baseMaxMana = 0;
        public int baseManaRegen = 0;

        public int attackPower = 0;
        public int attackDamage = 0;
        public double attackSpeed = 1;

        public int additionalAttackPower = 0;
        public int additionalAttackDamage = 0;
        public double additionalAttackSpeed = 0;

        public int baseAttackPower = 0;
        public int baseAttackDamage = 0;
        public int baseAttackSpeed = 0;

        public int healPower = 0;
        public int healValue = 0;


        public double DodgeChance { get; set; }
        public double BaseDodgeChance { get; set; }
        public double BlockChance { get; set; }
        public double BaseBlockChance { get; set; }
        public double ParryChance { get; set; }
        public double BaseParryChance { get; set; }

        public double BasicMagicResistChance { get; set; }
        public double AdditionalMagicResistChance { get; set; }

        public double MagicResistChance { get; set; }

        public int endurance = 0;
        public int stamina = 0;
        public int strength = 0;
        public int intellect = 0;
        public int agility = 0;

        public int AdditionalEndurance = 0;
        public int AdditionalStamina = 0;
        public int AdditionalStrength = 0;
        public int AdditionalIntellect = 0;
        public int AdditionalAgility = 0;

        public int baseEndurance = 1;
        public int baseStamina = 1;
        public int baseStrength = 1;
        public int baseIntellect = 1;
        public int baseAgility = 1;

        public int Armor { get; set; }
        public int WeaponDamage { get; set; }
        public double CriticalChance { get; set; }

        public int copper = 0;
        public int silver = 0;
        public int gold = 0;
        public string SaveTime { get; set; }
        public bool OutOfControl { get; set; }
        public bool FindTheWeakness { get; set; }
        public bool WideBlow { get; set; }
        public bool CrushLegs { get; set; }
        public bool DeepDefense { get; set; }
        public bool LastManStanding { get; set; }

        public bool IsBlocking { get; set; }
        public bool IsDodging { get; set; }
        public bool IsParrying { get; set; }

        public int Shield { get; set; }


        // statistic <-

        public int DaysPlayed { get; set; }

        public int EpicItems { get; set; }
        public int EnemiesKilled { get; set; }

        public List<int> EquipmentList { get; set; }


        // statistic ->

        public void SaveCharacter(Player player)
        {
            List<string> characterData = new List<string>
            {
                
            };

            characterData.Add(player.GetName());
            characterData.Add(Convert.ToString(player.GetLevel()));
            characterData.Add(player.GetGender());
            characterData.Add(Convert.ToString(player.GetExperience()));
            characterData.Add(Convert.ToString(player.GetMaxExperience()));
            characterData.Add(Convert.ToString(player.GetHealthPoints()));
            characterData.Add(Convert.ToString(player.GetMaxHP()));
            characterData.Add(Convert.ToString(player.GetEnergy()));
            characterData.Add(Convert.ToString(player.GetMaxEnergy()));
            characterData.Add(Convert.ToString(player.GetMana()));
            characterData.Add(Convert.ToString(player.GetMaxMana()));
            characterData.Add(Convert.ToString(player.GetAttackDamage()));
            characterData.Add(Convert.ToString(player.GetHealPower()));
            characterData.Add(Convert.ToString(player.GetEndurance()));
            characterData.Add(Convert.ToString(player.GetStamina()));
            characterData.Add(Convert.ToString(player.GetIntellect()));
            characterData.Add(Convert.ToString(player.GetAgility()));
            characterData.Add(Convert.ToString(player.GetStrength()));
            characterData.Add(Convert.ToString(player.copper));
            characterData.Add(Convert.ToString(player.silver));
            characterData.Add(Convert.ToString(player.gold));

                File.WriteAllLines("characterSave.txt", characterData);
        }

        public Player LoadCharacter()
        {
            string[] characterData = null;

            characterData = File.ReadAllLines("characterSave.txt");


            // set name and subname
            Player player = new Player(characterData[0], characterData[2]);

            player.SetLevel(Convert.ToInt32(characterData[1]));
            player.SetExperience(Convert.ToInt32(characterData[3]));
            player.SetMaxExperience();
            player.SetHealthPoints(Convert.ToInt32(characterData[5]));
            player.SetMaxHP(Convert.ToInt32(characterData[6]));
            player.SetEnergy(Convert.ToInt32(characterData[7]));
            player.SetMaxEnergy(Convert.ToInt32(characterData[8]));
            player.SetMana(Convert.ToInt32(characterData[9]));
            player.SetMaxMana(Convert.ToInt32(characterData[10]));
            player.SetAttackDamage(Convert.ToInt32(characterData[11]));
            player.SetHealPower(Convert.ToInt32(characterData[12]));
            player.SetEndurance(Convert.ToInt32(characterData[13]));
            player.SetStamina(Convert.ToInt32(characterData[14]));
            player.SetIntellect(Convert.ToInt32(characterData[15]));
            player.SetAgility(Convert.ToInt32(characterData[16]));
            player.SetStrength(Convert.ToInt32(characterData[17]));
            player.copper = (Convert.ToInt32(characterData[18]));
            player.silver = (Convert.ToInt32(characterData[19]));
            player.gold = (Convert.ToInt32(characterData[20]));

            return player;
        }
        public void LevelUp()
        {
            level += 1;
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int level)
        {
            this.level = level;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }

        public int GetExperience()
        {
            return experience;
        }

        public void SetExperience(int exp)
        {
            experience = exp;
        }

        public void NullExperience()
        {
            experience = 0;
        }

        public void AddExperience(int exp)
        {
            if (experience < maxExperience)
            {
                experience += exp;
            }
        }

        public void SetMaxExperience()
        {
            maxExperience = Math.Round(level * 10 * 1.2, 1);
        }

        public void SetHealthPoints(int healthPoints)
        {
            this.healthpoints = healthPoints;
        }
        public double GetMaxExperience()
        {
            return maxExperience;
        }

        public int GetHealthPoints()
        {
            return healthpoints;
        }

        public int GetMaxHP()
        {
            return maxHP;
        }

        public void SetMaxHP(int maxHP)
        {
            this.maxHP = maxHP;
        }

        public int GetEnergy()
        {
            return energy;
        }
        public void SetEnergy(int energy)
        {
            this.energy = energy;
        }
        public int GetMaxEnergy()
        {
            return maxEnergy;
        }

        public void SetMaxEnergy(int maxEnergy)
        {
            this.maxEnergy = maxEnergy;
        }

        public int GetMana()
        {
            return mana;
        }

        public void SetMana(int mana)
        {
            this.mana = mana;
        }

        public int GetMaxMana()
        {
            return maxMana;
        }

        public void SetMaxMana(int maxMana)
        {
            this.maxMana = maxMana;
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetAttackDamage()
        {
            return attackDamage;
        }

        public void SetAttackDamage(int attackDamage)
        {
            this.attackDamage = attackDamage;
        }

        public int GetHealPower()
        {
            return healPower;
        }

        public void SetHealPower(int healPower)
        {
            this.healPower = healPower;
        }
        public int GetEndurance()
        {
            return endurance;
        }

        public void SetEndurance(int endurance)
        {
            this.endurance = endurance;
        }

        public int GetStamina()
        {
            return stamina;
        }

        public void SetStamina(int stamina)
        {
            this.stamina = stamina;
        }
        public int GetStrength()
        {
            return strength;
        }

        public void SetStrength(int strength)
        {
            this.strength = strength;
        }

        public int GetIntellect()
        {
            return intellect;
        }

        public void SetIntellect(int intellect)
        {
            this.intellect = intellect;
        }
        public int GetAgility()
        {
            return agility;
        }
        public void SetAgility(int agility)
        {
            this.agility = agility;
        }
        public void AddEndurance(int value)
        {
            endurance += value;
        }

        public void AddStamina(int value)
        {
            stamina += value;
        }
        public void AddStrength(int value)
        {
            strength += value;
        }

        public void AddIntellect(int value)
        {
            intellect += value;
        }

        public void AddAgility(int value)
        {
            agility += value;
        }

        


        public virtual void RefreshStats()
        {
            endurance = AdditionalEndurance + baseEndurance;
            stamina = AdditionalStamina + baseStamina;
            strength = AdditionalStrength + baseStrength;
            intellect = AdditionalIntellect + baseIntellect;
            agility = AdditionalAgility + baseAgility;

            healthpoints = ((AdditionalStamina + baseStamina) * 10 + BaseHP);
            maxHP = ((AdditionalStamina + baseStamina) * 10) + BaseHP;

            energy = (AdditionalEndurance + baseEndurance) * 10;
            maxEnergy = (AdditionalEndurance + baseEndurance) * 10;

            mana = (AdditionalIntellect + baseIntellect) * 10;
            maxMana = (AdditionalIntellect + baseIntellect) * 10;

            attackPower = additionalAttackPower + WeaponDamage + strength * 2;


            healthRegen = (additionalHealthRegen + baseHealthRegen);
            if (healthRegen < 1)
            {
                healthRegen = 1;
            }

            manaRegen = (additionalManaRegen + baseManaRegen);
            if (manaRegen < 1)
            {
                manaRegen = 2;
            }

            energyRegen = (additionalEnergyRegen + baseEnergyRegen);
            if (energyRegen < 1)
            {
                energyRegen = 2;
            }

            CriticalChance = (AdditionalAgility + baseAgility);

            BlockChance = (AdditionalAgility + baseAgility) * 0.8;
            DodgeChance = (AdditionalAgility + baseAgility) * 2;
            ParryChance = (AdditionalAgility + baseAgility) * 1.5;

            BasicMagicResistChance = intellect;
            MagicResistChance = (BasicMagicResistChance / 2)  + AdditionalMagicResistChance;

            attackSpeed = 1;

        }

        public virtual void ScaleStaticStats()
        {
            RefreshStats();
        }
        public Player(string name, string gender)
        {
            this.name = name;
            this.gender = gender;

            RefreshStats();

            SetMaxExperience();
        }
        public Player()
        {

            RefreshStats();

            SetMaxExperience();
        }

        public int AttackDamageCalculator()
        {

            Random calculateAttack = new Random();
            attackDamage = calculateAttack.Next(Convert.ToInt32(attackPower * 0.7), Convert.ToInt32(attackPower * 1.3));


            return attackDamage;
        }

        public int HealCountCalculator()
        {
            Random calculateHealCount = new Random();
            healPower = calculateHealCount.Next(Convert.ToInt32(healPower * 0.6), Convert.ToInt32(healPower * 1.2));
            return healPower;
        }

        public void Hit(NPC npc)
        {
                npc.healthpoints -= AttackDamageCalculator();
                energy -= 3;

            if (npc.healthpoints < 0)
            {
                npc.healthpoints = 0;
            }
        }

        public void Heal(NPC npc)
        {
            healPower = HealCountCalculator();
            npc.healthpoints += healPower;

            if (npc.healthpoints > npc.maxHP)
            {
                npc.healthpoints = npc.maxHP;
            }


            this.mana -= Convert.ToInt32(intellect * 4);

            if (mana < 0)
            {
                mana = 0;
            }
        }

        public void Heal(Player player)
        {
            healPower = HealCountCalculator();
            player.healthpoints += healPower;

            if (player.healthpoints > player.maxHP)
            {
                player.healthpoints = player.maxHP;
            }

            if (player.maxHP - player.healthpoints < healPower)
            {
                healPower = player.maxHP - player.healthpoints;
            }

            this.mana -= Convert.ToInt32(intellect * 4);

            if (mana < 0)
            {
                mana = 0;
            }
        }

        public void Hit(Player player)
        {
            player.healthpoints -= AttackDamageCalculator();
            energy -= 3;

            if (player.healthpoints < 0)
            {
                player.healthpoints = 0;
            }
        }

        public void Recover()
        {
            if (healthpoints < maxHP)
            {
                healthpoints += healthRegen;

                if (healthpoints > maxHP)
                {
                    healthpoints = maxHP;
                }
            }

            if (energy < maxEnergy)
            {
                energy += energyRegen;
                if (energy > maxEnergy)
                {
                    energy = maxEnergy;
                }
            }

            if (mana < maxMana)
            {
                mana += manaRegen;
                if (mana > maxMana)
                {
                    mana = maxMana;
                }
            }

            if (healthpoints < 0 && healthpoints == 0)
            {
                IsAlive = false;
                healthpoints = 0;
            }
        }

        public bool Parry()
        {
            Random parryChance = new Random();
            int parry = parryChance.Next(0, 100);

            if (parry <= ParryChance)
            {
                //IsParrying = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Dodge()
        {
            Random dodgeChance = new Random();
            int dodge = dodgeChance.Next(0, 100);

            if (dodge <= DodgeChance)
            {
                // IsDodging = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Block()
        {
            Random blockChance = new Random();
            int block = blockChance.Next(0, 100);

            if (block <= BlockChance)
            {
                // IsBlocking = true;
                return true;
            }
            else
            { 
                return false;
            }
        }

        public void OutTheDefense()
        {
            IsDodging = false;
            IsParrying = false;
            IsBlocking = false;
        }

        public bool InDefense()
        {
            if (IsDodging == true || IsBlocking == true || IsParrying == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool Resist()
        {
            Random resistChance = new Random();
            int resist = resistChance.Next(0, 100);

            if (resist <= MagicResistChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Alive()
        {
            if (healthpoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Strike(NPC npc)
        {

            energy -= 4;

            if (energy < 0)
            {
                energy = 0;
            }

            attackDamage = Convert.ToInt32(attackPower * 1.4);
            npc.healthpoints -= attackDamage;

            if (npc.healthpoints < 0)
            {
                npc.healthpoints = 0;
            }
        }

        public void Blow(NPC npc)
        {

            energy -= 6;

            if (energy < 0)
            {
                energy = 0;
            }

            attackDamage = Convert.ToInt32(attackPower * 1.8);
            npc.healthpoints -= attackDamage;

            if (npc.healthpoints < 0)
            {
                npc.healthpoints = 0;
            }
        }

        public void DefenceStance(NPC npc)
        {
            throw new NotImplementedException();
        }

        public void Rage(NPC npc)
        {
            throw new NotImplementedException();
        }

        public void Stun(NPC npc)
        {
            throw new NotImplementedException();
        }

        public void BattleStance(NPC npc)
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            List<string> data = new List<string> { };
            List<string> dataEquipment = new List<string> { };
            List<int> dataWeared = EquipmentValue.GetWearedIDs();

            Directory.CreateDirectory($"saves\\player\\{name}");

            data.Add(name);
            data.Add(Convert.ToString(level));
            data.Add(Convert.ToString(gender));
            data.Add(Convert.ToString(experience));
            data.Add(Convert.ToString(maxExperience));
            data.Add(Convert.ToString(Bio));

            data.Add(Specialization);

            data.Add(Convert.ToString(baseHealthpoints));
            data.Add(Convert.ToString(baseMaxHP));

            data.Add(Convert.ToString(baseEnergy));
            data.Add(Convert.ToString(baseMaxEnergy));

            data.Add(Convert.ToString(baseMana));
            data.Add(Convert.ToString(baseMaxMana));

            data.Add(Convert.ToString(baseAttackPower));
            data.Add(Convert.ToString(healPower));
            data.Add(Convert.ToString(BaseDodgeChance));

            data.Add(Convert.ToString(baseEndurance));
            data.Add(Convert.ToString(baseStamina));
            data.Add(Convert.ToString(baseStrength));
            data.Add(Convert.ToString(baseIntellect));
            data.Add(Convert.ToString(baseAgility));

            data.Add(Convert.ToString(copper));
            data.Add(Convert.ToString(silver));
            data.Add(Convert.ToString(gold));
            data.Add(Convert.ToString(DateTime.Now));


            data.Add(Convert.ToString(DaysPlayed));
            data.Add(Convert.ToString(EpicItems));
            data.Add(Convert.ToString(EnemiesKilled));


            data.Add(AvatarPath);

            data.Add(Convert.ToString(WeaponDamage));
            data.Add(Convert.ToString(attackSpeed));
            data.Add(Convert.ToString(Armor));

            data.Add(Convert.ToString(baseHealthRegen));
            data.Add(Convert.ToString(baseManaRegen));
            data.Add(Convert.ToString(baseEnergyRegen));

            data.Add(Convert.ToString(CriticalChance));
            data.Add(Convert.ToString(DodgeChance));
            data.Add(Convert.ToString(BlockChance));
            data.Add(Convert.ToString(ParryChance));

            data.Add(IconPath);

            // equip


            dataEquipment.Add(Convert.ToString(additionalHealthpoints));
            dataEquipment.Add(Convert.ToString(additionalMaxHP));
            dataEquipment.Add(Convert.ToString(additionalHealthRegen));

            dataEquipment.Add(Convert.ToString(additionalMana));
            dataEquipment.Add(Convert.ToString(additionalMaxMana));
            dataEquipment.Add(Convert.ToString(additionalManaRegen));

            dataEquipment.Add(Convert.ToString(additionalEnergy));
            dataEquipment.Add(Convert.ToString(additionalMaxEnergy));
            dataEquipment.Add(Convert.ToString(additionalEnergyRegen));

            dataEquipment.Add(Convert.ToString(additionalAttackPower));
            dataEquipment.Add(Convert.ToString(additionalAttackDamage));
            dataEquipment.Add(Convert.ToString(additionalAttackSpeed));

            dataEquipment.Add(Convert.ToString(AdditionalEndurance));
            dataEquipment.Add(Convert.ToString(AdditionalStamina));
            dataEquipment.Add(Convert.ToString(AdditionalStrength));
            dataEquipment.Add(Convert.ToString(AdditionalIntellect));
            dataEquipment.Add(Convert.ToString(AdditionalAgility));

            List<string> wearedList = new List<string> { };

            foreach (var item in dataWeared)
            {
                wearedList.Add(Convert.ToString(item));
            }

            File.WriteAllLines($"saves\\player\\{name}\\data.txt", data);
            File.WriteAllLines($"saves\\player\\{name}\\equipment.txt", dataEquipment);
            File.WriteAllLines($"saves\\player\\{name}\\weared.txt", wearedList);


            
        }

        public void LoadData(string name)
        {

            string[] data;
            string[] dataEquipment;
            string[] dataWeared;

            data = File.ReadAllLines($"saves\\player\\{name}\\data.txt");
            dataEquipment = File.ReadAllLines($"saves\\player\\{name}\\equipment.txt");
            dataWeared = File.ReadAllLines($"saves\\player\\{name}\\weared.txt");

           

            this.name = data[0];
            level = Convert.ToInt32(data[1]);
            gender = data[2];
            experience = Convert.ToInt32(data[3]);
            maxExperience = Convert.ToInt32(data[4]);
            Bio = data[5];

            Specialization = data[6];

            baseHealthpoints = Convert.ToInt32(data[7]);
            baseMaxHP = Convert.ToInt32(data[8]);

            baseEnergy = Convert.ToInt32(data[9]);
            baseMaxEnergy = Convert.ToInt32(data[10]);

            baseMana = Convert.ToInt32(data[11]);
            baseMaxMana = Convert.ToInt32(data[12]);

            baseAttackPower = Convert.ToInt32(data[13]);
            healPower = Convert.ToInt32(data[14]);
            DodgeChance = Convert.ToDouble(data[15]);

            baseEndurance = Convert.ToInt32(data[16]);
            baseStamina = Convert.ToInt32(data[17]);
            baseStrength = Convert.ToInt32(data[18]);
            baseIntellect = Convert.ToInt32(data[19]);
            baseAgility = Convert.ToInt32(data[20]);

            copper = Convert.ToInt32(data[21]);
            silver = Convert.ToInt32(data[22]);
            gold = Convert.ToInt32(data[23]);
            SaveTime = data[24];

            DaysPlayed = Convert.ToInt32(data[25]);
            EpicItems = Convert.ToInt32(data[26]);
            EnemiesKilled = Convert.ToInt32(data[27]);

            AvatarPath = data[28];

            WeaponDamage = Convert.ToInt32(data[29]);
            attackSpeed = Convert.ToDouble(data[30]);
            Armor = Convert.ToInt32(data[31]);

            baseHealthRegen = Convert.ToInt32(data[32]);
            baseManaRegen = Convert.ToInt32(data[33]);
            baseEnergyRegen = Convert.ToInt32(data[34]);


            CriticalChance = Convert.ToDouble(data[35]);
            DodgeChance = Convert.ToDouble(data[36]);
            BlockChance = Convert.ToDouble(data[37]);
            ParryChance = Convert.ToDouble(data[38]);

            IconPath = data[39];

            Avatar = Image.FromFile(AvatarPath);


            // equip

            additionalHealthpoints = Convert.ToInt32(dataEquipment[0]);
            additionalMaxHP = Convert.ToInt32(dataEquipment[1]);
            additionalHealthRegen = Convert.ToInt32(dataEquipment[2]);

            additionalMana = Convert.ToInt32(dataEquipment[3]);
            additionalMaxMana = Convert.ToInt32(dataEquipment[4]);
            additionalManaRegen = Convert.ToInt32(dataEquipment[5]);

            additionalEnergy = Convert.ToInt32(dataEquipment[6]);
            additionalMaxEnergy = Convert.ToInt32(dataEquipment[7]);
            additionalEnergyRegen = Convert.ToInt32(dataEquipment[8]);

            additionalAttackPower = Convert.ToInt32(dataEquipment[9]);
            additionalAttackDamage = Convert.ToInt32(dataEquipment[10]);
            additionalAttackSpeed = Convert.ToInt32(dataEquipment[11]);

            AdditionalEndurance = Convert.ToInt32(dataEquipment[12]);
            AdditionalStamina = Convert.ToInt32(dataEquipment[13]);
            AdditionalStrength = Convert.ToInt32(dataEquipment[14]);
            AdditionalIntellect = Convert.ToInt32(dataEquipment[15]);
            AdditionalAgility = Convert.ToInt32(dataEquipment[16]);

            Data.Player = this;

            // weared

            if (ArmoryData.Armory == null)
            {
                ArmoryData.InitializeArmory();
            }

            InventoryData.PlayerEquipment.Initialize();

            EquipmentValue.NullWeared();


            EquipmentValue.Add(Convert.ToInt32(dataWeared[0]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[1]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[2]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[3]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[4]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[5]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[6]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[7]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[8]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[9]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[10]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[11]));
            EquipmentValue.Add(Convert.ToInt32(dataWeared[12]));


            EquipmentValue.InitializeValues();

        }

    }
}
