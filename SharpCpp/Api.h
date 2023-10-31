#pragma once

#ifdef CSHARP_EXPORT
#define CSHARP_API __declspec(dllexport)
#else
#define CSHARP_API __declspec(dllimport)
#endif  // CSHARP_EXPORT
