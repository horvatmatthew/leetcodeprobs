/**
 * Definition for singly-linked list.*/
  function ListNode(val, next) {
      this.val = (val===undefined ? 0 : val)
      this.next = (next===undefined ? null : next)
  }

/**
 * @param {ListNode} list1
 * @param {ListNode} list2
 * @return {ListNode}
 */
 var mergeTwoLists = function(list1, list2) {
     let returnList = new ListNode();
     let returnHead = returnList;

    while(list1 !== null || list2 !== null) {
         if(list1 === null) {
             returnList.next = new ListNode(list2.val);
             returnList = returnList.next;
             list2 = list2.next;
         } else if(list2 === null) {
             returnList.next = new ListNode(list1.val)
             returnList = returnList.next;
             list1 = list1.next;
         } else if(list1.val < list2.val) {
             returnList.next = new ListNode(list1.val);
             returnList = returnList.next;
             list1 = list1.next;
         } else if(list2.val < list1.val) {
             returnList.next = new ListNode(list2.val);
             returnList = returnList.next;
             list2 = list2.next;
         } else if(list1.val === list2.val) {
             returnList.next = new ListNode(list1.val);
             returnList = returnList.next;
             list1 = list1.next;
             returnList.next = new ListNode(list2.val);
             returnList = returnList.next;
             list2 = list2.next;
         }
     }

     return returnHead.next;
    
};

let list1 = new ListNode();
let list2 = new ListNode(0,null);

console.log(mergeTwoLists(list1, list2));