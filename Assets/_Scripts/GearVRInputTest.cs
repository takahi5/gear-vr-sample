using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearVRInputTest : MonoBehaviour
{
  [SerializeField] GearVRInput m_GearVRInput;
  [SerializeField] Text m_text;


  private void OnEnable()
  {
    m_GearVRInput.OnTriggerDown += HandleTriggerDown;
    m_GearVRInput.OnTriggerUp += HandleTriggerUp;
    m_GearVRInput.OnSwipeUp += HandleSwipeUp;
    m_GearVRInput.OnSwipeDown += HandleSwipeDown;
    m_GearVRInput.OnSwipeLeft += HandleSwipeLeft;
    m_GearVRInput.OnSwipeRight += HandleSwipeRight;
    m_GearVRInput.OnTouchPadButtonDown += HandleTouchPadButtonDown;
    m_GearVRInput.OnTouchPadButtonUp += HandleTouchPadButtonUp;
    m_GearVRInput.OnTouchPadTouchDown += HandleTouchPadTouchDown;
    m_GearVRInput.OnTouchPadTouchUp += HandleTouchPadTouchUp;
  }

  private void OnDisable()
  {
    m_GearVRInput.OnTriggerDown -= HandleTriggerDown;
    m_GearVRInput.OnTriggerUp -= HandleTriggerUp;
    m_GearVRInput.OnSwipeUp -= HandleSwipeUp;
    m_GearVRInput.OnSwipeDown -= HandleSwipeDown;
    m_GearVRInput.OnSwipeLeft -= HandleSwipeLeft;
    m_GearVRInput.OnSwipeRight -= HandleSwipeRight;
    m_GearVRInput.OnTouchPadButtonDown -= HandleTouchPadButtonDown;
    m_GearVRInput.OnTouchPadButtonUp -= HandleTouchPadButtonUp;
    m_GearVRInput.OnTouchPadTouchDown -= HandleTouchPadTouchDown;
    m_GearVRInput.OnTouchPadTouchUp -= HandleTouchPadTouchUp;
  }

  private void HandleTriggerDown()
  {
    m_text.text = "Trigger Down\n" + m_text.text;
  }

  private void HandleTriggerUp()
  {
    m_text.text = "Trigger Up\n" + m_text.text;
  }

  private void HandleSwipeUp()
  {
    m_text.text = "Swipe Up\n" + m_text.text;
  }

  private void HandleSwipeDown()
  {
    m_text.text = "Swipe Down\n" + m_text.text;
  }

  private void HandleSwipeLeft()
  {
    m_text.text = "Swipe Left\n" + m_text.text;
  }

  private void HandleSwipeRight()
  {
    m_text.text = "Swipe Right\n" + m_text.text;
  }

  private void HandleTouchPadButtonDown()
  {
    m_text.text = "Touch Pad Button Down\n" + m_text.text;
  }

  private void HandleTouchPadButtonUp()
  {
    m_text.text = "Touch Pad Button Up\n" + m_text.text;
  }

  private void HandleTouchPadTouchDown()
  {
    m_text.text = "Touch Pad Touch Down\n" + m_text.text;
  }

  private void HandleTouchPadTouchUp()
  {
    m_text.text = "Touch Pad Touch Up\n" + m_text.text;
  }



}
