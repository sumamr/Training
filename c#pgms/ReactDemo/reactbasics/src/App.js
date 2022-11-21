import logo from './logo.svg';
import './App.css';
import Header from './Header'
import Content from './Content'
import ClassComponent from './components/ClassComponent'
import { ClassComponentState } from './components/ClassComponentState'
import { DemoForm } from './DemoForm'
import { SimpleInterest } from './SimpleInterest'
import { FetchAPIDemo } from './components/FetchAPIDemo';
import TodoApp from './components/TodoApp';
import UpdateTodo from'./components/UpdateTodo'
function App() {
    const emp = {
        id: 1,
        name: "Suma",
        course: "React",
        duration:"7 days"
    }
    return (
        <div className="App">
            <h1> WELCOME</h1>
            <Header></Header>
            <ClassComponent course={emp} />
            <ClassComponentState />
            
            <DemoForm />
            <SimpleInterest />
            <FetchAPIDemo />
            <TodoApp/>
            <UpdateTodo></UpdateTodo>
         </div>
        
    );
}

export default App;
