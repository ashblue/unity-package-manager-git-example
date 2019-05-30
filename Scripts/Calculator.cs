using UnityEngine;

namespace CleverCrow.UnityPackageGitExample {
    public class Calculator : MonoBehaviour {
        private readonly CalculatorInternal _internal = new CalculatorInternal();

        public CalculatorInternal Internal => _internal;
        
        private void Start () {
            _internal.Add(2);
        }
    }

    public class CalculatorInternal : ICalculator {
        private int _total;
        public int Total => _total;

        public void Add (int number) {
            _total += number;
        }

        public void Add (ICalculator calculator) {
            _total += calculator.Total;
        }
    }
}
