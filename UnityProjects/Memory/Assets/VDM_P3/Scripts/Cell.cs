using UnityEngine;
using System.Collections;

namespace Memory
{
    public class Cell : MonoBehaviour
    {
        // Assets
        public Sprite hiddenSprite;
        public Sprite[] shownSprites;

        // Components
        private SpriteRenderer sr;
        private GameController gc;

        // State
        private bool isShown = false;
        public Sprite currentShownSprite;

        #region Setup
        void Awake()
        {
            sr = this.GetComponent<SpriteRenderer>();
            gc = FindObjectOfType<GameController>();
        }

        public void AssignSpriteIndex(int index)
        {
            this.currentShownSprite = this.shownSprites[index];
        }
        #endregion

        #region Interaction
        void OnMouseUp()
        {
            if (isShown) return;

            switch (gc.currentTurnState)
                {
                    case TurnState.NO_SELECTION:
                        SetShown();
                        gc.AssignFirstCell(this);
                        break;

                    case TurnState.FIRST_SELECTED:
                        SetShown();
                        gc.AssignSecondCell(this);
                        break;
                }
            }
         
        #endregion

        #region Show / Hide
        public void SetShown()
        {
            isShown = true;
            this.sr.sprite = currentShownSprite;
        }
        public void SetHidden()
        {
            isShown = false;
            this.sr.sprite = hiddenSprite;
        }
        #endregion

        #region Recoloring
        public void Recolor()
        {
            // TODO: assign a random color to this cell
        }
        #endregion
    }
}
