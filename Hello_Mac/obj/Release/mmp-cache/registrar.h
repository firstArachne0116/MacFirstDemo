#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>
#import <CoreGraphics/CoreGraphics.h>
#import <CloudKit/CloudKit.h>

@class MvvmCross_Platforms_Mac_Views_Base_MvxEventSourceTabViewController;
@class MvvmCross_Platforms_Mac_Views_MvxTabViewController;
@class MvvmCross_Platforms_Mac_Views_MvxTabViewController_1;
@class MvvmCross_Platforms_Mac_Views_Base_MvxEventSourceViewController;
@class MvvmCross_Platforms_Mac_Views_MvxViewController;
@class MvvmCross_Platforms_Mac_Views_MvxViewController_1;
@class MvvmCross_Platforms_Mac_Views_MvxWindowController;
@class NSApplicationDelegate;
@class MvvmCross_Platforms_Mac_Core_MvxApplicationDelegate;
@class MvvmCross_Platforms_Mac_Core_MvxApplicationDelegate_2;
@class MvxTableCellView;
@class MvxTableColumn;
@class MvvmCross_Platforms_Mac_Binding_Views_MvxView;
@class NSTableViewSource;
@class MvvmCross_Platforms_Mac_Binding_Views_MvxTableViewSource;
@class __monomac_internal_ActionDispatcher;
@class NSOutlineViewDataSource;
@class NSOutlineViewDelegate;
@class NSTableViewDataSource;
@class NSTableViewDelegate;
@class Foundation_InternalNSNotificationHandler;
@class Foundation_NSDispatcher;
@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class __Xamarin_NSTimerActionDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class AppKit_NSTableView__NSTableViewDelegate;
@class __NSGestureRecognizerToken;
@class __NSGestureRecognizerParameterlessToken;
@class __NSGestureRecognizerParametrizedToken;
@class __NSClickGestureRecognizer;
@class __NSMagnificationGestureRecognizer;
@class __NSPanGestureRecognizer;
@class __NSPressGestureRecognizer;
@class __NSRotationGestureRecognizer;
@class AppKit_NSTextField__NSTextFieldDelegate;
@class AppKit_NSSearchField__NSSearchFieldDelegate;
@class AppKit_NSTabView__NSTabViewDelegate;
@class AppKit_NSText__NSTextDelegate;
@class AppKit_NSTextView__NSTextViewDelegate;
@class __NSObject_Disposer;
@class OpenTK_Platform_MacOS_MonoMacGameView;
@class AppDelegate;
@class LoginDialogController;
@class Hello_Mac_MessageTableDataSource;
@class Hello_Mac_MessageTableDelegate;
@class Hello_Mac_SourceListDelegate;
@class Hello_Mac_SourceListDataSource;
@class ViewController;
@class SourceListView;
@class Hello_Mac_SourceListItem;

@interface MvvmCross_Platforms_Mac_Views_Base_MvxEventSourceTabViewController : NSTabViewController {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) loadView;
	-(void) viewDidLoad;
	-(void) viewDidLayout;
	-(void) viewWillAppear;
	-(void) viewDidAppear;
	-(void) viewWillDisappear;
	-(void) viewDidDisappear;
	-(void) tabView:(NSTabView *)p0 didSelectTabViewItem:(NSTabViewItem *)p1;
	-(void) tabView:(NSTabView *)p0 willSelectTabViewItem:(NSTabViewItem *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Views_MvxTabViewController : MvvmCross_Platforms_Mac_Views_Base_MvxEventSourceTabViewController {
}
	-(void) viewDidLoad;
	-(void) viewWillAppear;
	-(void) viewDidAppear;
	-(void) viewWillDisappear;
	-(void) viewDidDisappear;
	-(void) prepareForSegue:(NSStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) removeFromParentViewController;
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Views_MvxTabViewController_1 : MvvmCross_Platforms_Mac_Views_MvxTabViewController {
}
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Views_Base_MvxEventSourceViewController : NSViewController {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) loadView;
	-(void) viewDidLoad;
	-(void) viewDidLayout;
	-(void) viewWillAppear;
	-(void) viewDidAppear;
	-(void) viewWillDisappear;
	-(void) viewDidDisappear;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Views_MvxViewController : MvvmCross_Platforms_Mac_Views_Base_MvxEventSourceViewController {
}
	-(void) viewDidLoad;
	-(void) viewWillAppear;
	-(void) viewDidAppear;
	-(void) viewWillDisappear;
	-(void) viewDidDisappear;
	-(void) prepareForSegue:(NSStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) removeFromParentViewController;
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Views_MvxViewController_1 : MvvmCross_Platforms_Mac_Views_MvxViewController {
}
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Views_MvxWindowController : NSWindowController {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface NSApplicationDelegate : NSObject<NSApplicationDelegate> {
}
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Core_MvxApplicationDelegate : NSObject<NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillBecomeActive:(NSNotification *)p0;
	-(void) applicationDidResignActive:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Core_MvxApplicationDelegate_2 : MvvmCross_Platforms_Mac_Core_MvxApplicationDelegate<NSApplicationDelegate> {
}
	-(id) init;
@end

@interface MvxTableCellView : NSTableCellView {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(CGRect) frame;
	-(void) setFrame:(CGRect)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface MvxTableColumn : NSTableColumn {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) setValue:(NSObject *)p0 forKey:(NSString *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Binding_Views_MvxView : NSView {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface NSTableViewSource : NSObject {
}
	-(id) init;
@end

@interface MvvmCross_Platforms_Mac_Binding_Views_MvxTableViewSource : NSObject {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(NSInteger) numberOfRowsInTableView:(NSTableView *)p0;
	-(NSView *) tableView:(NSTableView *)p0 viewForTableColumn:(NSTableColumn *)p1 row:(NSInteger)p2;
	-(void) tableViewSelectionDidChange:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface NSOutlineViewDataSource : NSObject<NSOutlineViewDataSource> {
}
	-(id) init;
@end

@interface NSOutlineViewDelegate : NSObject<NSOutlineViewDelegate> {
}
	-(id) init;
@end

@interface NSTableViewDataSource : NSObject<NSTableViewDataSource> {
}
	-(id) init;
@end

@interface NSTableViewDelegate : NSObject<NSTableViewDelegate> {
}
	-(id) init;
@end

@interface __NSGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __NSGestureRecognizerParameterlessToken : __NSGestureRecognizerToken {
}
	-(void) target;
@end

@interface __NSGestureRecognizerParametrizedToken : __NSGestureRecognizerToken {
}
	-(void) target:(NSGestureRecognizer *)p0;
@end

@interface OpenTK_Platform_MacOS_MonoMacGameView : NSView {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) drawRect:(CGRect)p0;
	-(void) lockFocus;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithFrame:(CGRect)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface AppDelegate : NSObject<NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface LoginDialogController : NSViewController {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) viewWillAppear;
	-(void) AcceptDialog:(NSObject *)p0;
	-(void) CancelDialog:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface Hello_Mac_MessageTableDataSource : NSObject<NSTableViewDataSource> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(NSInteger) numberOfRowsInTableView:(NSTableView *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface Hello_Mac_MessageTableDelegate : NSObject<NSTableViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(NSView *) tableView:(NSTableView *)p0 viewForTableColumn:(NSTableColumn *)p1 row:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface Hello_Mac_SourceListDelegate : NSObject<NSOutlineViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(BOOL) outlineView:(NSOutlineView *)p0 shouldEditTableColumn:(NSTableColumn *)p1 item:(NSObject *)p2;
	-(NSCell *) outlineView:(NSOutlineView *)p0 dataCellForTableColumn:(NSTableColumn *)p1 item:(NSObject *)p2;
	-(BOOL) outlineView:(NSOutlineView *)p0 isGroupItem:(NSObject *)p1;
	-(NSView *) outlineView:(NSOutlineView *)p0 viewForTableColumn:(NSTableColumn *)p1 item:(NSObject *)p2;
	-(BOOL) outlineView:(NSOutlineView *)p0 shouldSelectItem:(NSObject *)p1;
	-(void) outlineViewSelectionDidChange:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface Hello_Mac_SourceListDataSource : NSObject<NSOutlineViewDataSource> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(NSInteger) outlineView:(NSOutlineView *)p0 numberOfChildrenOfItem:(NSObject *)p1;
	-(BOOL) outlineView:(NSOutlineView *)p0 isItemExpandable:(NSObject *)p1;
	-(NSObject *) outlineView:(NSOutlineView *)p0 child:(NSInteger)p1 ofItem:(NSObject *)p2;
	-(NSObject *) outlineView:(NSOutlineView *)p0 objectValueForTableColumn:(NSTableColumn *)p1 byItem:(NSObject *)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ViewController : NSViewController {
}
	@property (nonatomic, assign) NSTableColumn * DateColumn;
	@property (nonatomic, assign) id FollowList;
	@property (nonatomic, assign) NSTableColumn * MessageColumn;
	@property (nonatomic, assign) NSTableView * MessageTable;
	@property (nonatomic, assign) NSTableColumn * SectionColumn;
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(NSTableColumn *) DateColumn;
	-(void) setDateColumn:(NSTableColumn *)p0;
	-(id) FollowList;
	-(void) setFollowList:(id)p0;
	-(NSTableColumn *) MessageColumn;
	-(void) setMessageColumn:(NSTableColumn *)p0;
	-(NSTableView *) MessageTable;
	-(void) setMessageTable:(NSTableView *)p0;
	-(NSTableColumn *) SectionColumn;
	-(void) setSectionColumn:(NSTableColumn *)p0;
	-(void) viewDidLoad;
	-(NSObject *) representedObject;
	-(void) setRepresentedObject:(NSObject *)p0;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SourceListView : NSOutlineView {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface Hello_Mac_SourceListItem : NSObject {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end


