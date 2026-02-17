namespace SwuCube.Core.Models;

public class CardData
{
    public int printingId { get; set; }
    public int cardId { get; set; }
    public string cardName { get; set; }
    public bool isUnique { get; set; }
    public bool isToken { get; set; }
    public string title { get; set; }
    public int cardType { get; set; }
    public string cardTypeDescription { get; set; }
    public int cost { get; set; }
    public string[] traits { get; set; }
    public int[] aspects { get; set; }
    public int power { get; set; }
    public int hitPoints { get; set; }
    public int powerBonus { get; set; }
    public int hitPointBonus { get; set; }
    public int arena { get; set; }
    public string arenaDescription { get; set; }
    public string frontAbilityText { get; set; }
    public string backAbilityText { get; set; }
    public int variantType { get; set; }
    public string frontImagePath { get; set; }
    public string backImagePath { get; set; }
    public bool isFrontPortrait { get; set; }
    public bool isBackPortrait { get; set; }
}