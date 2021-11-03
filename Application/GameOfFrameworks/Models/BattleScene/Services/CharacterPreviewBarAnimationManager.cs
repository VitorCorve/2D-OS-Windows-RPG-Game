using GameEngine.CombatEngine.Actions;
using System.Timers;
using System.Windows;

namespace GameOfFrameworks.Models.BattleScene.Services
{
    public class CharacterPreviewBarAnimationManager
    {
        private CharacterPreviewBarModel CharacterBar;
        private Timer GridAnimationTimer;
        private Timer AttributesAnimationTimer;
        private Timer StaticStatementTimer;
        private int StaticStatementTimerCount;
        public bool AnimationInProcess { get; private set; }
        public SERVICE_OWNER Owner { get; set; }
        public CharacterPreviewBarAnimationManager(CharacterPreviewBarModel characterBar, SERVICE_OWNER owner)
        {
            CharacterBar = characterBar;
            Owner = owner;
            InitializeDefaultStatement();
        }
        public void InitializeDefaultStatement()
        {
            CharacterBar.AttributesGridMargin = SetThicknessForServiceOwner(140);
            CharacterBar.AttributesGridOpacity = 0.0;
            CharacterBar.AttributesGridVisibility = Visibility.Visible;
            CharacterBar.AttributesOpacity = 0.0;
            CharacterBar.AttributesVisibility = Visibility.Visible;
        }
        public void ShowControl()
        {
            GridAnimationTimer = new Timer(1);
            GridAnimationTimer.Elapsed += ShowControl_Elapsed;
            GridAnimationTimer.Start();
            AnimationInProcess = true;
        }
        public void HideControl()
        {
            GridAnimationTimer = new Timer(1);
            GridAnimationTimer.Elapsed += HideControl_Elapsed;
            GridAnimationTimer.Start();
            AnimationInProcess = true;
            CharacterBar.AttributesOpacity = 0.0;
        }
        private void ShowControl_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (GetOwnerThicknessKeyValue() > 0)
            {
                CharacterBar.AttributesGridMargin = SetThicknessForServiceOwner(GetOwnerThicknessKeyValue() - 6);
            }
            else
            {
                CharacterBar.AttributesGridMargin = new Thickness(0, 0, 0, 0);
                GridAnimationTimer.Stop();
                ShowAttributes();
            }
        }
        private void HideControl_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (GetOwnerThicknessKeyValue() < 140)
            {
                CharacterBar.AttributesGridMargin = SetThicknessForServiceOwner(GetOwnerThicknessKeyValue() + 6);
            }
            else
            {
                GridAnimationTimer.Stop();
                HideAttributes();
            }
        }
        private void ShowAttributes_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (CharacterBar.AttributesOpacity < 1.0)
            {
                CharacterBar.AttributesOpacity += 0.01;
            }
            else
            {
                AttributesAnimationTimer.Stop();
                AnimationInProcess = false;
                StartCheckingStatemenet();
            } 
        }
        private void HideAttributes_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (CharacterBar.AttributesOpacity < 0.0)
            {
                CharacterBar.AttributesOpacity -= 0.01;
            }
            else
            {
                AttributesAnimationTimer.Stop();
                AnimationInProcess = false;
            }
        }
        private void ShowAttributes()
        {
            AttributesAnimationTimer = new Timer(5);
            AttributesAnimationTimer.Elapsed += ShowAttributes_Elapsed;
            AttributesAnimationTimer.Start();
        }
        private void HideAttributes()
        {
            AttributesAnimationTimer = new Timer(5);
            AttributesAnimationTimer.Elapsed += HideAttributes_Elapsed;
            AttributesAnimationTimer.Start();
        }
        private void StartCheckingStatemenet()
        {
            StaticStatementTimer = new Timer(1000);
            StaticStatementTimerCount = 0;
            StaticStatementTimer.Elapsed += StaticStatementTimer_Check;
            StaticStatementTimer.Start();
        }

        private void StaticStatementTimer_Check(object sender, ElapsedEventArgs e)
        {
            if (AnimationInProcess) return;
            if (StaticStatementTimerCount < 4)
            {
                StaticStatementTimerCount++;
            }
            else
            {
                HideControl();
                StaticStatementTimer.Stop();
            }
        }
        private Thickness SetThicknessForServiceOwner(double value)
        {
            if (Owner is SERVICE_OWNER.Player)
                return new Thickness(0, 0, value, 0);
            else
                return new Thickness(value, 0, 0, 0);
        }
        private double GetOwnerThicknessKeyValue()
        {
            if (Owner is SERVICE_OWNER.Player)
                return CharacterBar.AttributesGridMargin.Right;
            else
                return CharacterBar.AttributesGridMargin.Left;
        }

    }
}
