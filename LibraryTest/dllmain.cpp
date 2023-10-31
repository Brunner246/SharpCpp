// dllmain.cpp : Defines the entry point for the DLL application.
#include "../SharpCpp/SharpCpp.h"
#include "CwAPI3D.h"

CWAPI3D_PLUGIN bool plugin_x64_init(CwAPI3D::ControllerFactory* aFactory);

bool plugin_x64_init(CwAPI3D::ControllerFactory* aFactory) {
  aFactory->getUtilityController()->printToConsole(L"hello world");
  mainTest();

  return false;
}
