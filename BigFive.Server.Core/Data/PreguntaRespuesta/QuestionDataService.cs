using System.Collections.Generic;
using System.Linq;
using BigFive.Server.Core.Common;

namespace BigFive.Server.Core.Data.PreguntaRespuesta
{
    public class QuestionDataService : IQuestionRepository
    {



        public IQuestion GetQuestionById(int index)
        {
            var query = from q in QuestionsDataObjectService.GetBigFiveQuestions()
                        where q.Index == index
                        select q;

            return (Question)query.First();

        }


        public List<Question> GetAllQuestion()
        {
            var questionList = new List<Question>();

            var query = from questions in QuestionsDataObjectService.GetBigFiveQuestions()

                        select questions;
            foreach (var question in query)
            {
                questionList.Add(new Question() { Index = question.Index, Statement = question.Statement });
            }
            return questionList;
        }



    }


    public class QuestionsDataObjectService
    {

        //cambair a IQuestion
        public static List<Question> GetBigFiveQuestions()
        {

            var questions = new List<Question>
                                {
                                    new Question
                                        {
                                            Statement = "Creo que soy una persona vigorosa y activa",
                                            Index = 1
                                        },

                                    new Question
                                        {
                                            Statement = "Me gusta hacer las cosas razonado demasiado sobre ellas",
                                            Index = 2
                                        },

                                    new Question
                                        {
                                            Statement =
                                                "Tiendo a implicarme demasiado cuando alguien me cuenta su problemas",
                                            Index = 3
                                        },

                                    new Question
                                        {
                                            Statement =
                                                "No me preocupan especialmente las consecuencias de mis actos puedan tener a los demás",
                                            Index = 4
                                        },

                                    new Question
                                        {
                                            Statement = "Estoy siempre informado sobre lo que sucede en el mundo",
                                            Index = 5
                                        },

                                    new Question
                                        {
                                            Statement = "Nunca he dicho una mentira"
                                            ,
                                            Index = 6
                                        },

                                    new Question
                                        {
                                            Statement =
                                                "No me gusta las actividades que exigen empeñarse y esforzarse hasta el agotamiento"
                                            ,
                                            Index = 7
                                        },

                                    new Question
                                        {
                                            Statement = "Tiendo a ser muy reflexivo"
                                            ,
                                            Index = 8
                                        },


                                    new Question
                                        {
                                            Statement = "No suelo sentirme tenso"
                                            ,
                                            Index = 9
                                        },

                                    new Question
                                        {

                                            Statement = "Noto fácilmente cuando las personas necesitan mi ayuda"
                                            ,
                                            Index = 10
                                        },


                                    new Question
                                        {
                                            Statement = "No recuerdo fácilmente los números de teléfonos que son largos",
                                            Index = 11
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "Siempre he estado completamente de acuerdo con los demás",
                                            Index = 12
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Generalmente tiendo a imponerme a las otras personas, más que a condescender con ellas",
                                            Index = 13
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Ante los obstáculos grandes, no conviene en empeñarse en conseguir objetivos propios",
                                            Index = 14
                                        }
                                    ,
                                    new Question {Statement = "Soy más bien susceptible", Index = 15}
                                    ,
                                    new Question
                                        {
                                            Statement = "No es necesario comportase cordialmente con todas las personas",
                                            Index = 16
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "No me siento muy atraído por las situaciones nuevas e inesperadas",
                                            Index = 17
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Siempre he resuelto de inmediato todos los problemas que he encontrado",
                                            Index = 18
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "No me gustan los ambientes de trabajo donde hay mucha competitividad",
                                            Index = 19
                                        }
                                    ,
                                    new Question {Statement = "Llevo a cabo las decisiones que he tomado", Index = 20}
                                    ,
                                    new Question
                                        {
                                            Statement = "No es fácil que algo o alguien me haga perder la paciencia",
                                            Index = 21
                                        }
                                    ,
                                    new Question {Statement = "No me gusta mezclarme con la gente", Index = 22}
                                    ,
                                    new Question {Statement = "Toda novedad me entusiasma", Index = 23}
                                    ,
                                    new Question
                                        {
                                            Statement = "Nunca me he asustado ante el peligro aunque sea grave",
                                            Index = 24
                                        }
                                    ,
                                    new Question {Statement = "Tiendo a decidir rápidamente", Index = 25}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Antes de tomar cualquier iniciativa me tomo el tiempo para valorar las posibles consecuencias",
                                            Index = 26
                                        }
                                    ,
                                    new Question {Statement = "No creo ser una persona ansiosa", Index = 27}
                                    ,
                                    new Question
                                        {
                                            Statement = "No suelo saber cómo actuar ante las desgracias de mis amigos",
                                            Index = 28
                                        }
                                    ,
                                    new Question {Statement = "Tengo buena memoria", Index = 29}
                                    ,
                                    new Question
                                        {
                                            Statement = "Siempre he estado absolutamente seguro de todas mis acciones",
                                            Index = 30
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "En mi trabajo no le concedo especial importancia a rendir mejor que los demás",
                                            Index = 31
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "No me gusta vivir  de manera demasiado metódica y ordenada",
                                            Index = 32
                                        }
                                    ,
                                    new Question
                                        {Statement = "Me siento vulnerable a las críticas de los demás", Index = 33}
                                    ,
                                    new Question
                                        {
                                            Statement = "Si es preciso, no tengo inconveniente en ayudar a un desconocido",
                                            Index = 34
                                        }
                                    ,
                                    new Question
                                        {Statement = "No me atraen situaciones en constante cambio", Index = 35}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Nunca he desobedecido las órdenes recibidas, ni siquiera siendo niño",
                                            Index = 36
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "No me gustan aquellas actividades en las que es preciso ir de un sitio a otro y moverse continuamente",
                                            Index = 37
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "No creo que sea preciso esforzarse más allá del límite de las propias fuerzas, incluso aunque haya que cumplir algún plazo",
                                            Index = 38
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "estoy dispuesto en esforzarme al máximo con tal de destacar",
                                            Index = 39
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Si tengo que criticar a los demás lo hago sobre todo cuando se lo merecen",
                                            Index = 40
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Creo que no hay valores y costumbres totalmente válidos y eternos",
                                            Index = 41
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Para enfrentarme a un problema no es efectivo tener presente muchos puntos de vista diferentes",
                                            Index = 42
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "En general no me irrito ni siquiera en situaciones en las que tendría motivos suficientes para ellos",
                                            Index = 43
                                        }
                                    ,
                                    new Question
                                        {Statement = "Si me equivoco siempre me resulta fácil admitirlo", Index = 44}
                                    ,
                                    new Question {Statement = "Cuando me enfado manifiesto mal humor", Index = 45}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Llevo a cabo lo que he decidido aún que me suponga un esfuerzo no previsto",
                                            Index = 46
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "No pierdo tiempo en aprender cosas que no estén estrictamente relacionas con mi campo de interés",
                                            Index = 47
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "Casi siempre se cómo ajustarme a las exigencias de los demás",
                                            Index = 48
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Llevo adelante las tareas emprendidas aunque los resultado iniciales parezcan negativos",
                                            Index = 49
                                        }
                                    ,
                                    new Question {Statement = "No suelo sentirme solo y triste", Index = 50}
                                    ,
                                    new Question
                                        {Statement = "No me gusta hacer varias cosas al mismo tiempo", Index = 51}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Habitualmente muestro una actitud cordial  incluso con las personas que no me provocan una cierta empatía",
                                            Index = 52
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Amenudeo estoy completamente absorbido por mis compromisos y actividades",
                                            Index = 53
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Cuando algo entorpece mis proyectos no insisto en conseguirlos e intento otros",
                                            Index = 54
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "No me interesan los programas televisivos que me exigen esfuerzo e implicación",
                                            Index = 55
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "Soy una persona que siempre busca nuevas experiencias",
                                            Index = 56
                                        }
                                    ,
                                    new Question{Statement = "Me molesta mucho el desorden", Index = 57}
                                    ,
                                    new Question{Statement = "No suelo reaccionar de modo impulsivo", Index = 58}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                             "Siempre encuentro buenos argumentos para sostener mis propuestas y convencer a los demás de su validez",
                                            Index = 59
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "Me gusta estar bien informado incluso sobre temas alejados de mi ámbito de competencias",
                                            Index = 60
                                        }
                                    ,
                                    new Question
                                        {Statement = "No doy mucha importancia a demostrar mis capacidades", Index = 61}
                                    ,
                                    new Question{Statement = "Mi humor pasa por altos y bajos frecuente", Index = 62}
                                    ,
                                    new Question
                                        {Statement = "A veces me enfado por cosa de poca importancia", Index = 63}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "No hago fácilmente un préstamo ni siquiera a personas que conozco bien",
                                            Index = 64
                                        }
                                    ,
                                    new Question {Statement = "No me gusta estar en grupos numerosos", Index = 65}
                                    ,
                                    new Question
                                        {
                                            Statement = "No suelo planificar mi vida hasta en los mas pequeños detalles",
                                            Index = 66
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement = "Nunca me ha interesado la vida y costumbres de otros pueblos",
                                            Index = 67
                                        }
                                    ,
                                    new Question {Statement = "No dudo en decir lo que pienso", Index = 68}
                                    ,
                                    new Question {Statement = "A menudo me noto inquieto", Index = 69}
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "En general no es conveniente mostrarse sensible a los problemas de los demás",
                                            Index = 70
                                        }
                                    ,
                                    new Question
                                        {
                                            Statement =
                                                "En las reuniones no me preocupo especialmente por llamar la atención",
                                            Index = 71
                                        }
                                    ,
                                    new Question
                                        { Statement = "Creo que todo problema puede ser resulto de varias maneras",  Index = 72 }
                                    ,
                                    new Question
                                        { Statement =  "Si creo que tengo razonamiento convencer a los demás aunque me cueste tiempo y energía",  Index = 73 }
                                    ,
                                    new Question
                                        {Statement = "Normalmente tiendo a no fijarme mucho en mi prójimo", Index = 74}


                                    ,new Question{Statement = "Difícilmente desisto de una actividad que he comenzado", Index = 75}
                                    ,new Question {Statement = "No Suelo perder la calma ", Index = 76}
                                    ,new Question{Statement = "No dedico mucho tiempo a la lectura", Index = 77}
                                    ,new Question{Statement =  "Normalmente no entablo conversación con compañeros ocasionales de viaje" , Index = 78}
                                    ,new Question{Statement = "A veces soy tan escrupuloso que puedo resultar pesado " , Index = 79}
                                   ,new Question{Statement = "Siempre me he comportado de modo completamente desinteresado" , Index = 80}
                                    ,new Question{Statement = "No tengo dificultada para controlar mis sentimientos" , Index = 81}
                                    ,new Question{Statement = "Nunca he  sido perfeccionista" ,Index = 82}
                                    ,new Question{Statement = "En diversas circunstancia me he comportado impulsivamente" , Index = 83}
                                    ,new Question{Statement = "Nunca he discutido ni peleado con otra persona" , Index = 84}
                                    ,new Question{Statement = "Es inútil empeñarse totalmente en algo por que la perfección no se alcanza nunca" , Index = 85}
                                    ,new Question{Statement = "Tengo en gran consideración el punto de vista de mis compañeros" , Index= 86}
                                    ,new Question{Statement = "Siempre me han apasionado las ciencias" , Index = 87}
                                    ,new Question{Statement = "Me resulta fácil hacer confidencias a los demás" , Index = 88}
                                    ,new Question{Statement = "Normalmente no reacciono de modo exagerado ni siquiera ante las emociones fuertes" , Index = 89}

                                    ,new Question{Statement =  "No creo que conocer la historia sirva de mucho" , Index =90}
                                    ,new Question{Statement = "No suelo reaccionar a las provocaciones" , Index = 91}
                                    ,new Question{Statement = "Nada de lo que he hecho podría haberlo hecho mejor" , Index = 92}
                                    ,new Question {Statement ="Creo que todas las personas tiene algo bueno " , Index  = 93}
                                    ,new Question { Statement = "Me resulta fácil hablar con personas que no conozco" , Index =  94}
                                    ,new Question{Statement = "No creo que haya posibilidad de convencer a otro cuando no piensa como nosotros" , Index = 95}
                                    ,new Question{Statement = "Si fracaso en algo, lo intento de nuevo hasta que lo consigo" , Index  = 96}
                                    ,new Question{Statement = "Siempre me han fascinado las culturas muy diferentes a la mía" , Index = 97}
                                    ,new Question{Statement = " A Menudo me siento nervioso" , Index = 98}
                                    ,new Question{Statement = "No soy una persona habladora" , Index = 99}
                                    ,new Question{Statement = "No merece mucho la pena ajustarse a las exigencias de los compañeros, cuando ello supone una disminución del propio ritmo del trabajo" , Index= 100}
                                    ,new Question {Statement = "Siempre he comprendido de inmediato todo lo que he leído" , Index = 101}
                                    ,new Question{Statement = "Siempre estoy seguro de  mí mismo" , Index  =  102 }
                                    ,new Question{ Statement = "No comprendo que empuja a las personas a comportase de modo de modo diferente a la normal" , Index  = 103}
                                    ,new Question {Statement = "No me molesta mucho que me interrumpan mientras que estoy haciendo algo que me interese", Index =  104}
                                    ,new Question {Statement = "Me gusta mucho ver programas de información cultural o científica" , Index  = 105}
                                    ,new Question{Statement = "Antes de entregar un trabajo dedico mucho tiempo a revisarlos" , Index = 106}
                                    ,new Question {Statement = "Si algo no se desarrolla tan pronto como deseaba, no insisto demasiado" , Index = 107}
                                    ,new Question{Statement = "Si es preciso no dudo en decir a los demás que se metan en sus asuntos", Index  = 108}
                                    , new Question {Statement = "Si alguna acción mía puede llegar a desagradar a alguien seguramente dejo de hacerla" , Index  = 109}
                                    ,new Question{Statement = "Cuando un trabajo está terminado no me pongo a repasarlo en sus mínimos detalles" , Index  = 110}
                                    ,new Question { Statement = "Estoy convencido que se obtienen mejores resultados cooperando con los demás que compitiendo", Index = 111}
                                    ,new Question{Statement = "Prefiero leer a practicar una actividad deportiva", Index  = 112}
                                    ,new Question{Statement = "Nunca he criticado a otras personas" ,Index  = 113}
                                    ,new Question{Statement = "Afronto todas mis actividades y experiencia con gran entusiasmo", Index = 114}
                                    ,new Question {Statement = "Solo quedo satisfecho cuando veo los resultados de lo que había programado", Index  =115}
                                    ,new Question {Statement = "Cuando me critican, no puedo evitar exigir explicaciones", Index = 116}
                                    ,new Question {Statement = "No se obtiene nada de la vida sin ser competitivo", Index = 117}
                                    ,new Question {Statement = "Siempre intento ver las cosas desde distintos enfoques", Index = 118}
                                    ,new Question {Statement = "Incluso en situaciones muy difíciles no pierdo el control", Index = 119}
                                    ,new Question{Statement = "A veces incluso pequeñas dificultades pueden llegar a preocuparme " , Index  = 120}
                                    ,new Question { Statement = "Generalmente no me comporto de manera abierta con los extraños" , Index = 121}
                                    ,new Question {Statement= "No suelo cambiar de humor bruscamente", Index  = 122}
                                    ,new Question {Statement = "No me gustan las actividades que implican riesgo " , Index = 123}
                                    ,new Question {Statement = "Nunca he tenido mucho interés por los temas científicos filosóficos" , Index  = 124}
                                    ,new Question {Statement = "Cuando empiezo a hacer algo , nuca estoy seguro si lo terminare" , Index  = 125}
                                    ,new Question {Statement = "Generalmente confió en los demás y en sus intenciones ", Index = 126}
                                    ,new Question{Statement = "Siempre he mostrado simpatía por todas la personas que he conocido", Index = 127}
                                    ,new Question{Statement = "Con ciertas personas no es necesario se demasiado tolerante", Index  = 128}
                                    ,new Question{Statement = "Suelo cuidar todas las cosas hasta en sus mínimos detalles" , Index = 129}
                                    ,new Question {Statement = "No es trabajando en grupo como se pueden desarrollar mejor las propias capacidades" ,Index  = 130}
                                    ,new Question {Statement= "No suelo buscar soluciones nuevas a problemas para los que ya existe una solución eficaz" , Index = 131}
                                    ,new Question {Statement = "No creo que sea util perder el tiempo repasando varias veses el trabajo hecho", Index = 132}


                                };

            return questions;
        }


    }
}