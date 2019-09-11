
		   alter table [Event] add constraint fk_EventUser
		   FOREIGN KEY([UserCode]) REFERENCES [dbo].[Users](UserCode)

		   
		   alter table [Event] add constraint fk_EventType
		   FOREIGN KEY([EventTypeCode]) REFERENCES [dbo].[EventType]([EventTypeCode])

		   
		   alter table [Task] add constraint fk_TaskEvent
		   FOREIGN KEY([EventCode]) REFERENCES [dbo].[Event](EventCode)

		   
		   alter table [SubTask] add constraint fk_SubTask
		   FOREIGN KEY([TaskCode]) REFERENCES [dbo].[Task](TaskCode)


		   
		   alter table [Task] add constraint fk_Task
		   FOREIGN KEY([ProfessionalCode]) REFERENCES [dbo].[Professional](ProfessionalCode)

		     alter table [Professional] add constraint fk_Professional
		   FOREIGN KEY([ProfessionalTypeCode]) REFERENCES [dbo].[ProfessionalType](ProfessionalTypeCode)