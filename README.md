# Varjo Unreal Examples

Unreal example projects. Folders are explained under:

-----------------------------------------------------------------------------------------------------

## VarjoSample

Using eye tracking API, device buttons and VR Controllers with Unreal Engine and Varjo headset.
Follow the next steps to get example scene and features running with Varjo headset.

###### Controller and eye tracking interactions

- Instructions on how to use controllers and eye tracking to interact with the scene can be found 
  from the scene as a text which is floating in the air.
	
- The blueprint that contains all of the controller logic can be found from following file:
  UnrealExamples\VarjoSample\Content\ControllerSetup\BP_VR_Pawn.uasset.
  
- The blueprint that contains default input logic including keyboard controls can be found from following file:
  UnrealExamples\VarjoSample\Content\ControllerSetup\BP_VR_Controller.uasset.
	
- The blueprint which handles the eye tracking interactions can be found from following file:
  UnrealExamples\VarjoSample\Content\VarjoContent\Blueprints\BP_Actor_Selection.uasset.
  
- The blueprint which saves the eye tracking data can be found from following blueprint function library file: 
  UnrealExamples\VarjoSample\Content\VarjoContent\Blueprints\BPFL_Util.uasset.
  At the end of every session, GazeData file will be saved in UnrealExamples\VarjoSample\Saved\Gaze_YYYYMMDD_HHMMSS.csv

- The Level Blueprint of the Minimal_Default level handles device button events and eye tracking
  calibration requests. You can open the Level Blueprint editor from:
  Blueprints -> Open Level Blueprint

###### Keyboard controls
- WASD - movement
- QE - up/down
- ZX - rotate
- ESC - quit
	
-----------------------------------------------------------------------------------------------------

## HOWTO_CreatePawn 

Simple example howto create pawn for headset that can be moved and rotated with keys.
