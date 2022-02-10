/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */

  function ListNode(val, next) {
      this.val = (val===undefined ? 0 : val)
      this.next = (next===undefined ? null : next)
  }

  var addTwoNumbers = function(l1, l2) {
    let totalHead = new ListNode();
    let total = totalHead;
    
    let left = l1;
    let right = l2;
    let carryOver = 0;

    while(left != null || right != null) {
        let working = 0;
        if(left == null) {
            working = right.val + carryOver;
        } else if(right == null) {
            working = left.val + carryOver;
        } else {
            working = left.val + right.val + carryOver;
        }
        let sum = Math.floor(working % 10);
        carryOver = Math.floor(working/10);
        let temp = new ListNode(sum);
        if(left != null) {
         left = left.next;
        }
        if(right != null) {
            right = right.next;
        }
        total.next = temp;
        total = total.next;
    }

    if(carryOver > 0) {
        let temp = new ListNode(carryOver);
        total.next = temp;
        total = total.next;
    }

    return totalHead.next;
};

let l1 = {};
l1.val = 2;
l1.next = {}
l1.next.val = 4;
l1.next.next = {};
l1.next.next.val = 3;

let l2 = {};
l2.val = 5;
l2.next = {};
l2.next.val = 6;
l2.next.next = {};
l2.next.next.val = 4;

console.log(addTwoNumbers(l1,l2));