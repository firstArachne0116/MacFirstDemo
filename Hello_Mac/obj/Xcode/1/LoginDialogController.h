// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface LoginDialogController : NSViewController {
	NSButton *_AcceptButton;
	NSTextField *_email;
	NSSecureTextField *_password;
}

@property (nonatomic, retain) IBOutlet NSButton *AcceptButton;

@property (nonatomic, retain) IBOutlet NSTextField *email;

@property (nonatomic, retain) IBOutlet NSSecureTextField *password;

- (IBAction)AcceptDialog:(id)sender;

- (IBAction)CancelDialog:(id)sender;

@end
