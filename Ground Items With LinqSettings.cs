﻿using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using Newtonsoft.Json;
using SharpDX;
using System.Collections.Generic;

namespace Ground_Items_With_Linq
{
    public class Ground_Items_With_LinqSettings : ISettings
    {
        //Mandatory setting to allow enabling/disabling your plugin
        public ToggleNode Enable { get; set; } = new ToggleNode(false);

        public List<GroundRule> GroundRules { get; set; } = new List<GroundRule>();
        public RangeNode<int> UpdateTimer { get; set; } = new RangeNode<int>(500, 0, 5000);
        public RangeNode<float> TextSize { get; set; } = new RangeNode<float>(1f, 1f, 20f);

        public ToggleNode EnableTextDrawing { get; set; } = new ToggleNode(true);
        public RangeNode<int> TextPadding { get; set; } = new RangeNode<int>(5, 1, 60);
        public ColorNode LabelTrim { get; set; } = new ColorNode(new Color(214, 0, 255, 255));
        public ColorNode LabelBackground { get; set; } = new ColorNode(new Color(214, 0, 255, 255));
        public ColorNode LabelText { get; set; } = new ColorNode(new Color(214, 0, 255, 255));
        public ToggleNode OrderByDistance { get; set; } = new ToggleNode(true);

        public ToggleNode EnableMapDrawing { get; set; } = new ToggleNode(true);
        public ColorNode MapLineColor { get; set; } = new ColorNode(new Color(214, 0, 255, 255));
        public RangeNode<float> MapLineThickness { get; set; } = new RangeNode<float>(2.317f, 1f, 10f);

        //Socket + Links Emulation Params
        public RangeNode<int> EmuSocketSize { get; set; } = new RangeNode<int>(6, 1, 60);
        public RangeNode<int> EmuSocketSpacing { get; set; } = new RangeNode<int>(4, 4, 60);
        public ColorNode EmuRedSocket { get; set; } = new ColorNode(new Color(201, 13, 50, 255));
        public ColorNode EmuGreenSocket { get; set; } = new ColorNode(new Color(158, 202, 13, 255));
        public ColorNode EmuBlueSocket { get; set; } = new ColorNode(new Color(88, 130, 254, 255));
        public ColorNode EmuWhiteSocket { get; set; } = new ColorNode(Color.White);
        public ColorNode EmuLinkColor { get; set; } = new ColorNode(new Color(195, 195, 195, 255));


        [JsonIgnore]
        public ButtonNode ReloadFilters { get; set; } = new ButtonNode();
    }
}

public class GroundRule
{
    public string Name { get; set; } = "";
    public string Location { get; set; } = "";
    public bool Enabled { get; set; } = false;
    public GroundRule(string name, string location, bool enabled)
    {
        Name = name;
        Location = location;
        Enabled = enabled;
    }
}