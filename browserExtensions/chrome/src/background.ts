import {testTool} from "./Tools";

chrome.runtime.onInstalled.addListener(() => {
  // chrome.storage.sync.set({}, () => {
  // });
});

chrome.tabs.onUpdated.addListener(((tabId, changeInfo, tab) => {
  if (changeInfo.status === 'complete') {
    testTool();
  }
}));

chrome.contextMenus.create({
  title: 'Report Covid-19 B.S.',
  contexts: ['link', 'selection'],
  onclick: function(e){
    console.log('hey you did something', e);
  }

}, function(){})
