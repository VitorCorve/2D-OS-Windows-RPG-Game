namespace GameOfFrameworks.Models.CharacterCreation.Services
{
    public static class ConvertCharacterNickname
    {
        public static string Convert(string nickname)
        {
            nickname = nickname.Replace(" ", "");
            char[] chars = nickname.ToCharArray();
            chars[0] = char.ToUpper(chars[0]);
            return new string(chars);
        }
    }
}
