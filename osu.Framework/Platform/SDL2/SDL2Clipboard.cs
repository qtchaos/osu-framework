// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using SDL2;
using SixLabors.ImageSharp;

namespace osu.Framework.Platform.SDL2
{
    public class SDL2Clipboard : Clipboard
    {
        public override string? GetText() => SDL.SDL_GetClipboardText();

        public override void SetText(string text) => SDL.SDL_SetClipboardText(text);

        public override Image<TPixel>? GetImage<TPixel>()
        {
            return null;
        }

        public override bool SetImage(Image image)
        {
            return false;
        }
    }
}
