#pragma once

namespace NM115 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace ZedGraph;

	/// <summary>
	/// —водка дл€ main_form
	/// </summary>
	public ref class main_form : public System::Windows::Forms::Form
	{
	public:

		main_form(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~main_form()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: ZedGraph::ZedGraphControl^  zedGraphControl1;
	protected:

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->zedGraphControl1 = (gcnew ZedGraph::ZedGraphControl());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(71, 428);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 30);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Say Hello";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &main_form::button1_Click_1);
			// 
			// zedGraphControl1
			// 
			this->zedGraphControl1->IsShowPointValues = false;
			this->zedGraphControl1->Location = System::Drawing::Point(239, 24);
			this->zedGraphControl1->Name = L"zedGraphControl1";
			this->zedGraphControl1->PointValueFormat = L"G";
			this->zedGraphControl1->Size = System::Drawing::Size(350, 350);
			this->zedGraphControl1->TabIndex = 1;
			this->zedGraphControl1->Load += gcnew System::EventHandler(this, &main_form::zedGraphControl1_Load);
			// 
			// main_form
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(640, 480);
			this->Controls->Add(this->zedGraphControl1);
			this->Controls->Add(this->button1);
			this->Name = L"main_form";
			this->Text = L"DiffUr";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button1_Click_1(System::Object^  sender, System::EventArgs^  e) 
	{
		MessageBox::Show("Hello World",
			"My heading", MessageBoxButtons::OKCancel,
			MessageBoxIcon::Asterisk);
	}
	private: System::Void zedGraphControl1_Load(System::Object^  sender, System::EventArgs^  e) {
		
	}
	};
}
