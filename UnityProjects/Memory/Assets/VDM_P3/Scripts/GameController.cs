using UnityEngine;
using System.Collections;

namespace Memory
{

    public enum TurnState
    {
        NO_SELECTION,
        FIRST_SELECTED,
        SECOND_SELECTED
    }

    public class GameController : MonoBehaviour
    {
        public TurnState currentTurnState;
        public Grid grid;

        private int totCorrectPairs;

        #region Setup
        void Start()
        {
            ResetGame();
        }

        void ResetGame()
        {
            totCorrectPairs = 0;
            currentTurnState = TurnState.NO_SELECTION;
            grid.ResetToHidden();
        }
        #endregion

        #region Cell Interaction
        private Cell c1;
        private Cell c2;

        public void AssignFirstCell(Cell c)
        {
            this.c1 = c;
            currentTurnState = TurnState.FIRST_SELECTED;
        }
        public void AssignSecondCell(Cell c)
        {
            this.c2 = c;
            currentTurnState = TurnState.SECOND_SELECTED;

            CheckCorrectness();
        }
        #endregion

        void CheckCorrectness()
        {
            bool correct = (c1.currentShownSprite == c2.currentShownSprite);

            if (correct)
            {
                // Keep going...
                totCorrectPairs++;
                if (totCorrectPairs == Grid.ROW_LENGTH * Grid.COL_LENGTH)
                {
                    Debug.Log("YOU WIN!");
                    return;
                }
            }
            else
            {
                // Wrong!!!
                Invoke("ResetGame", 0.5f);
            }
            currentTurnState = TurnState.NO_SELECTION;
        }

    }

}
