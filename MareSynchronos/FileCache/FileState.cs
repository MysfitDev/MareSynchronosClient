﻿using MareSynchronos.Models;

namespace MareSynchronos.FileCache;


public enum FileState
{
    Valid,
    RequireUpdate,
    RequireDeletion
}
