﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using NAPS2.Config;

namespace NAPS2.Scan.Images
{
    public class NullThumbnailRenderer : ThumbnailRenderer
    {
        public NullThumbnailRenderer(IUserConfigManager userConfigManager) : base(userConfigManager)
        {
        }

        public override Bitmap RenderThumbnail(Bitmap b, int size)
        {
            return null;
        }
    }
}
